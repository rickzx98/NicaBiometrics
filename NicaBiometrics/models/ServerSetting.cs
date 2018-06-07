using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    internal class ServerSetting
    {
        public void SetServerAddress(string serverAddress)
        {
            Settings.Default._serverAddress = serverAddress;
        }

        public void SetCompany(string company)
        {
            Settings.Default._serverCompany = company;
        }

        public void SetTimeInUrl(string timeInUrl)
        {
            Settings.Default._serverTimeinUrl = timeInUrl;
        }

        public void SetTimeOutUrl(string timeOutUrl)
        {
            Settings.Default._serverTimeoutUrl = timeOutUrl;
        }


        public void SetEmployeeUrl(string employeeUrl)
        {
            Settings.Default._serverEmployeeUrl = employeeUrl;
        }

        public void Connect(out List<string> messages)
        {
            messages = new List<string>();

            if (string.IsNullOrEmpty(Settings.Default._serverCompany))
            {
                messages.Add("Company is required");
                return;
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default._serverAddress))
            {
                try
                {
                    var request =
                        (HttpWebRequest) WebRequest.Create(Settings.Default._serverAddress);

                    request.Method = "GET";
                    request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

                    var response = (HttpWebResponse) request.GetResponse();
                    Settings.Default._connectedServer = response.StatusCode == HttpStatusCode.OK;
                    messages.Add(WriteLog("Connected to server " + Settings.Default._serverAddress));
                    GetCompanyId(messages);
                }
                catch (Exception exception)
                {
                    Settings.Default._connectedServer = false;
                    messages.Add(WriteLog("Failed to connect to server " + Settings.Default._serverAddress));
                    messages.Add(WriteLog(Resources.MESSAGE_INVALID_SERVER_ADDRESS));
                    messages.Add(WriteLog(exception.Message));
                }
            }
            else
            {
                Settings.Default._connectedServer = false;
                messages.Add(WriteLog(Resources.MESSAGE_INVALID_SERVER_ADDRESS));
            }
        }

        private void GetCompanyId(List<string> messages)
        {
            try
            {
                var request =
                    (HttpWebRequest) WebRequest.Create(Settings.Default._serverAddress +
                                                       "/companies/search/findByName?name=" +
                                                       Settings.Default._serverCompany);

                request.Method = "GET";
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.ContentType = "application/json";
                var response = (HttpWebResponse) request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Settings.Default._serverCompanyValid = true;
                    using (var responseStream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(responseStream ?? throw new InvalidOperationException(),
                            Encoding.UTF8);
                        var json =
                            new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(reader.ReadToEnd());
                        var embedded = (Dictionary<string, object>) json["_embedded"];
                        var company = (Dictionary<string, object>) ((ArrayList) embedded["companies"])[0];
                        Settings.Default._serverCompanyId = int.Parse(company["id"].ToString());
                        messages.Add(WriteLog("Valid company ID: " + Settings.Default._serverCompanyId));
                    }
                }
                else
                {
                    Settings.Default._serverCompanyValid = false;
                    messages.Add(WriteLog(Resources.MESSAGE_FAILED_TO_GET_COMPANY));
                }
            }
            catch (Exception exception)
            {
                Settings.Default._serverCompanyValid = false;
                messages.Add(WriteLog(Resources.MESSAGE_FAILED_TO_GET_COMPANY));
                messages.Add(WriteLog(exception.Message));
            }
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }
    }
}