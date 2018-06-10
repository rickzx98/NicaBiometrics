﻿using System;
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
        private string _search;

        public void SetSearch(string search)
        {
            _search = search;
        }

        public void LoadDeviceEmployyes(out List<Employee> employees)
        {
            employees = new List<Employee>();
            if (Settings.Default._connected)
            {
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
            var currentEmployees = new List<Employee>();
            var employeeUrl = Settings.Default._serverAddress + Settings.Default._serverEmployeeUrl;
            employeeUrl = employeeUrl.Replace(CompanyId, companyId.ToString());
            GetEmployees(currentEmployees, employeeUrl);
            employees = currentEmployees.Where(employee => employee.FullName.ToLower().Contains(_search.ToLower()))
                .ToList();
        }


        private static void GetEmployees(List<Employee> employees, string employeeUrl)
        {
            var request =
                (HttpWebRequest) WebRequest.Create(employeeUrl);

            request.Method = "GET";
            request.ContentType = "Application/json";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

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
                    employees.Add(new Employee(id, pin, fullName));
                }
            }
        }

        public struct Employee : IEquatable<Employee>
        {
            public Employee(int id, int pin, string fullName)
            {
                Id = id;
                Pin = pin;
                FullName = fullName;
            }

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