using System;
using System.Collections.Generic;
using System.Net;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    internal class ServerSetting
    {
        private readonly UserSession _userSession;

        public ServerSetting(UserSession userSession)
        {
            _userSession = userSession;
        }

        public void SetServerAddress(string serverAddress)
        {
            Settings.Default._serverAddress = serverAddress;
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

            if (!string.IsNullOrWhiteSpace(Settings.Default._serverAddress))
            {
                try
                {
                    var request =
                        (HttpWebRequest) WebRequest.Create(Settings.Default._serverAddress);

                    request.Method = "GET";
                    request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                    request.Headers.Add("Authorization", _userSession.GetBasicAuthenticationHeaderValue());
                    var response = (HttpWebResponse) request.GetResponse();
                    Settings.Default._connectedServer = response.StatusCode == HttpStatusCode.OK;
                    messages.Add(WriteLog("Connected to server " + Settings.Default._serverAddress));
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

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }

        public void SetJarLocation(string jarLocation)
        {
            Settings.Default._serverJarLocation = jarLocation;
        }
    }
}