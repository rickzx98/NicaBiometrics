using System;
using System.Collections.Generic;
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
        private List<Employee> _savedEmployees;

        private string _search;

        public Employees(DeviceSetting deviceSetting)
        {
            _search = "";
            _toUpdateEmployees = new List<Employee>();
            _deviceSetting = deviceSetting;
            _savedEmployees = new List<Employee>();
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
                _deviceSetting.LoadEnrolledEmployees(out var employees, out var messages);
                _savedEmployees = employees;
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
            {
                employees = currentEmployees.Where(employee => employee.FullName.ToLower().Contains(_search.ToLower()))
                    .ToList();
            }
        }


        private void GetEmployees(List<Employee> employees, string employeeUrl)
        {
            var request =
                (HttpWebRequest) WebRequest.Create(employeeUrl);

            request.Method = "GET";
            request.ContentType = "Application/json";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

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
                        var pin = int.Parse(company["pin"].ToString());

                        var employee = new Employee(id, pin, fullName);
                        employee.IsChecked = _savedEmployees.Contains(employee);
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
                    if (deleted) _savedEmployees.Remove(employee);
                }
                else if (employee.ToSave)
                {
                    _deviceSetting.EnrollEmployee(employee, out var messages, out var enrolled);
                    messageList = messages;
                    if (enrolled) _savedEmployees.Add(employee);
                }
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