using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NicaBiometrics.models
{
    internal class Employees
    {
        private string _search;

        public void SetSearch(string search)
        {
            _search = search;
        }

        public void LoadEmployees(out List<Employee> employees)
        {
            employees = new List<Employee>();
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
                    var pin = int.Parse(company["ping"].ToString());
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