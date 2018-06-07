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
                var request =
                    (HttpWebRequest) WebRequest.Create(Settings.Default._serverAddress +
                                                       Settings.Default._serverTimeinUrl);
                request.Method = "POST";
                request.Accept = "application/json";

                var parsedContent = "{\"empId\":\"" + enollId + "\"}";
                var encoding = new ASCIIEncoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK) message = Resources.MESSAGE_CHECKED_IN + enollId;
                else message = Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId;
            }
            catch (Exception e)
            {
                Settings.Default._serverLogs.Add(e.Message);
                message = Resources.MESSAGE_FAILED_TO_CHEKED_IN + enollId;
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

                var parsedContent = "{\"empId\":\"" + enollId + "\"}";
                var encoding = new ASCIIEncoding();
                var bytes = encoding.GetBytes(parsedContent);
                var newStream = request.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
                var response = (HttpWebResponse) request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK) message = Resources.MESESAGE_CHECKED_OUT + enollId;
                else message = Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId;
            }
            catch (Exception e)
            {
                Settings.Default._serverLogs.Add(e.Message);
                message = Resources.MESSAGE_FAILED_TO_CHECKED_OUT + enollId;
            }
        }
    }
}