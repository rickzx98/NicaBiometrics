using System;
using System.Net;
using System.Text;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    internal class TimeReport
    {
        public void TimeIn(string enollId, out string message)
        {
            message = null;
            try
            {
                var url = Settings.Default._serverAddress +
                          Settings.Default._serverTimeinUrl;
                var request =
                    (HttpWebRequest) WebRequest.Create(url);
                request.Method = "POST";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                var parsedContent = "{\"empId\":\"" + enollId + "\"}";
                var encoding = new UTF8Encoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                message = response.StatusCode == HttpStatusCode.Created
                    ? WriteLog(Resources.MESSAGE_CHECKED_IN + enollId)
                    : WriteLog(Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId);
                Settings.Default._serverLogs.Add(WriteLog(url + " " + response.StatusCode));
            }
            catch (Exception e)
            {
                Settings.Default._serverLogs.Add(WriteLog(e.Message));
                message = WriteLog(Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId);
            }
        }


        public void TimeOut(string enollId, out string message)
        {
            message = null;
            try
            {
                var request =
                    (HttpWebRequest) WebRequest.Create(Settings.Default._serverAddress +
                                                       Settings.Default._serverTimeoutUrl);
                request.Method = "PUT";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                var parsedContent = "{\"empId\":\"" + enollId + "\"}";
                var encoding = new ASCIIEncoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                message = response.StatusCode == HttpStatusCode.Created
                    ? WriteLog(Resources.MESESAGE_CHECKED_OUT + enollId)
                    : WriteLog(Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId);
            }
            catch (Exception e)
            {
                Settings.Default._serverLogs.Add(WriteLog(e.Message));
                message = WriteLog(Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId);
            }
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }
    }
}