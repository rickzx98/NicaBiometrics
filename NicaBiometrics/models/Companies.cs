using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    public class Companies
    {
        private readonly UserSession _userSession;
        private string _search;

        public Companies(UserSession userSession)
        {
            _userSession = userSession;
        }

        public void SetSearch(string search)
        {
            _search = search;
        }

        public void Search(out List<Company> companies)
        {
            companies = new List<Company>();
            if (!string.IsNullOrWhiteSpace(Settings.Default._serverAddress))
                try
                {
                    var companyUrl = Settings.Default._serverAddress + Settings.Default._serverCompanyUrl +
                                     "/search/findByName?name=" + _search;
                    GetCompanies(companies, companyUrl);
                }
                catch (Exception exception)
                {
                    Settings.Default._serverLogs.Add(exception.Message);
                }
        }

        public void LoadCompanies(out List<Company> companies)
        {
            companies = new List<Company>();
            if (!string.IsNullOrWhiteSpace(Settings.Default._serverAddress))
                try
                {
                    var companyUrl = Settings.Default._serverAddress + Settings.Default._serverCompanyUrl;
                    GetCompanies(companies, companyUrl);
                }
                catch (Exception exception)
                {
                    Settings.Default._serverLogs.Add(exception.Message);
                }
        }

        private void GetCompanies(List<Company> companies, string companyUrl)
        {
            var request =
                (HttpWebRequest) WebRequest.Create(companyUrl);

            request.Method = "GET";
            request.ContentType = "Application/json";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.Headers.Add("Authorization", _userSession.GetBasicAuthenticationHeaderValue());
            var response = (HttpWebResponse) request.GetResponse();

            using (var sr =
                new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException()))
            {
                var json =
                    JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());

                foreach (var company in json["_embedded"]["companies"])
                {
                    var id = int.Parse(company["id"].ToString());
                    var name = company["name"].ToString();
                    var isChecked = Settings.Default._companies != null &&
                                    Settings.Default._companies.Contains(id + Company.Sep + name);
                    companies.Add(new Company(id, name, isChecked));
                }
            }
        }

        public void Save(List<Company> companies)
        {
            Settings.Default._companies = new StringCollection();
            companies.ForEach(company => Settings.Default._companies.Add(company.ToString()));
            Settings.Default.Save();
        }

        public void Load(out List<Company> companies)
        {
            companies = new List<Company>();
            if (Settings.Default._companies != null)
                foreach (var company in Settings.Default._companies)
                    companies.Add(new Company(company));
        }

        public struct Company : IEquatable<Company>
        {
            public const string Sep = "$sep;";

            public Company(int id, string name, bool isChecked)
            {
                Id = id;
                Name = name;
                IsChecked = isChecked;
            }

            public Company(string company)
            {
                Id = int.Parse(company.Substring(0, company.IndexOf(Sep, StringComparison.Ordinal)));
                Name = company.Substring(company.IndexOf(Sep, StringComparison.Ordinal) + 5);
                IsChecked = false;
            }

            public string Name { get; set; }
            public int Id { get; }
            public bool IsChecked { get; set; }

            public override bool Equals(object obj)
            {
                return obj is Company && Equals((Company) obj);
            }

            public bool Equals(Company other)
            {
                return Id == other.Id;
            }

            public override int GetHashCode()
            {
                return 2108858624 + Id.GetHashCode();
            }

            public override string ToString()
            {
                return Id + Sep + Name;
            }
        }
    }
}