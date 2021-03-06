﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    public class TimeReport
    {
        private readonly UserSession _userSession;

        public TimeReport(UserSession userSession)
        {
            _userSession = userSession;
        }

        public void TimeIn(string enollId, DateTime dateTime, out List<string> messages)
        {
            messages = new List<string>();
            try
            {
                var url = Settings.Default._serverAddress +
                          Settings.Default._serverTimeinUrl;
                var request =
                    (HttpWebRequest) WebRequest.Create(url);
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", _userSession.GetBasicAuthenticationHeaderValue());
                var parsedContent = "{\"empId\":\"" + enollId + "\", \"input\":\"" +
                                    dateTime.ToString("yyyy-MM-ddThh:mm:ss") +
                                    "\"}";
                Console.WriteLine("parsedContent", parsedContent);
                var encoding = new UTF8Encoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                var log = response.StatusCode == HttpStatusCode.Created
                    ? WriteLog(Resources.MESSAGE_CHECKED_IN + enollId)
                    : WriteLog(Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId);
                messages.Add(log);
                messages.Add(WriteLog(url + " " + response.StatusCode));
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
                messages.Add(WriteLog(Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId));
            }
        }


        public void TimeOut(string enollId, DateTime dateTime, out List<string> messages)
        {
            messages = new List<string>();
            try
            {
                var url = Settings.Default._serverAddress +
                          Settings.Default._serverTimeoutUrl;
                var request =
                    (HttpWebRequest) WebRequest.Create(url);
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", _userSession.GetBasicAuthenticationHeaderValue());
                var parsedContent = "{\"empId\":\"" + enollId + "\", \"input\":\"" +
                                    dateTime.ToString("yyyy-MM-ddThh:mm:ss") +
                                    "\"}";
                Console.WriteLine("parsedContent", parsedContent);
                var encoding = new ASCIIEncoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                var log = response.StatusCode == HttpStatusCode.OK
                    ? WriteLog(Resources.MESESAGE_CHECKED_OUT + enollId)
                    : WriteLog(Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId);
                messages.Add(log);
                messages.Add(WriteLog(url + " " + response.StatusCode));
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
                messages.Add(WriteLog(Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId));
            }
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }
    }
}