using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NicaBiometrics.models
{
    class ServerSetting
    {
        private int _port;

        public void SetIpAddress(String ipAddress)
        {
            Properties.Settings.Default._serverIpAddress = ipAddress;
        }

        public void SetPort(int port)
        {
            Properties.Settings.Default._serverPort = port;
        }


        public Boolean ValidateIpAddress()
        {
            IPAddress IpAdd;
            return IPAddress.TryParse(Properties.Settings.Default._serverIpAddress, out IpAdd);
        }

        public void Connect()
        {
            var request =
                (HttpWebRequest) WebRequest.Create("https://api.github.com/repos/restsharp/restsharp/releases");

            request.Method = "GET";
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var response = (HttpWebResponse) request.GetResponse();

            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }

            Console.WriteLine(content);
        }
    }
}