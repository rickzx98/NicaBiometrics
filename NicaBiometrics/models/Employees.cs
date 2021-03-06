﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    internal class Employees
    {
        private const string CompanyId = "${companyId}";
        private readonly DeviceSetting _deviceSetting;
        private readonly List<Employee> _toUpdateEmployees;
        private readonly UserSession _userSession;

        private string _search;

        public Employees(DeviceSetting deviceSetting, UserSession userSession)
        {
            _search = "";
            _toUpdateEmployees = new List<Employee>();
            _deviceSetting = deviceSetting;
            _userSession = userSession;
        }

        public void SetSearch(string search)
        {
            _search = search;
        }

        public void LoadDeviceEmployees(out List<string> messageList)
        {
            messageList = new List<string>();
            if (Settings.Default._connected)
            {
                Settings.Default._savedEmployees = new StringCollection();
                _deviceSetting.LoadEnrolledEmployees(out var employees, out var messages);
                if (employees != null && employees.Count > 0)
                    foreach (var employee in employees)
                        Settings.Default._savedEmployees.Add(employee.Id.ToString());

                messageList = messages;
            }
        }

        public void LoadEmployees(out List<Employee> employees, int companyId)
        {
            employees = new List<Employee>();
            var employeeUrl = Settings.Default._serverAddress + Settings.Default._serverEmployeeUrl;
            employeeUrl = employeeUrl.Replace(CompanyId, companyId.ToString());
            GetEmployees(employees, employeeUrl);
        }

        public void SearchEmployees(out List<Employee> employees, int companyId)
        {
            employees = new List<Employee>();
            var currentEmployees = new List<Employee>();
            var employeeUrl = Settings.Default._serverAddress + Settings.Default._serverEmployeeUrl;
            employeeUrl = employeeUrl.Replace(CompanyId, companyId.ToString());
            GetEmployees(currentEmployees, employeeUrl);
            if (currentEmployees.Count > 0)
                employees = currentEmployees.Where(employee => employee.FullName.ToLower().Contains(_search.ToLower()))
                    .ToList();
        }


        private void GetEmployees(List<Employee> employees, string employeeUrl)
        {
            var request =
                (HttpWebRequest) WebRequest.Create(employeeUrl);

            request.Method = "GET";
            request.ContentType = "Application/json";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.Headers.Add("Authorization", _userSession.GetBasicAuthenticationHeaderValue());
            try
            {
                var response = (HttpWebResponse) request.GetResponse();

                using (var sr =
                    new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException()))
                {
                    var json =
                        JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());
                    foreach (var company in json["_embedded"]["employees"])
                    {
                        var id = int.Parse(company["id"].ToString());
                        var fullName = company["fullName"].ToString();
                        var pin = company["pin"] != null && company["pin"].HasValues
                            ? int.Parse(company["pin"].ToString())
                            : 0;

                        var employee = new Employee(id, pin, fullName);
                        employee.IsChecked = Settings.Default._savedEmployees != null &&
                                             Settings.Default._savedEmployees.Contains(employee.Id.ToString());
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception e)
            {
                Settings.Default._serverLogs.Add(WriteLog(e.Message));
            }
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }

        public void ToggleEmployee(Employee employee)
        {
            _toUpdateEmployees.Add(employee);
        }

        public void SaveEmployees(out List<string> messageList)
        {
            messageList = new List<string>();
            foreach (var employee in _toUpdateEmployees)
                if (employee.ToDelete)
                {
                    _deviceSetting.DeleteEnrolledEmployee(employee, out var messages, out var deleted);
                    messageList = messages;
                    if (deleted)
                        Settings.Default._savedEmployees.Remove(employee.Id.ToString());
                }
                else if (employee.ToSave)
                {
                    _deviceSetting.EnrollEmployee(employee, out var messages, out var enrolled);
                    messageList = messages;
                    if (enrolled) Settings.Default._savedEmployees.Add(employee.Id.ToString());
                }

            Settings.Default.Save();
        }

        public struct Employee : IEquatable<Employee>
        {
            public Employee(int id, int pin, string fullName)
            {
                Id = id;
                Pin = pin;
                FullName = fullName;
                IsChecked = false;
                ToSave = false;
                ToDelete = false;
            }

            public bool ToSave { get; set; }
            public bool ToDelete { get; set; }

            public bool IsChecked { get; set; }
            public int Id { get; set; }

            public string FullName { get; set; }

            public int Pin { get; set; }

            public override bool Equals(object obj)
            {
                return obj is Employee && Equals((Employee) obj);
            }

            public bool Equals(Employee other)
            {
                return Id == other.Id;
            }

            public override int GetHashCode()
            {
                return 2108858624 + Id.GetHashCode();
            }
        }
    }
}