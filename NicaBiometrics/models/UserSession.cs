using System;
using System.Text;
using NicaBiometrics.Properties;

namespace NicaBiometrics.models
{
    public class UserSession
    {
        public void SetUsername(string username)
        {
            Settings.Default._serverUsername = username;
        }

        public void SetPassword(string password)
        {
            Settings.Default._serverPassword = password;
        }

        private byte[] GetBase64()
        {
            return Encoding.ASCII.GetBytes(Settings.Default._serverUsername + ":" + Settings.Default._serverPassword);
        }

        public string GetBasicAuthenticationHeaderValue()
        {
            return "Basic " + Convert.ToBase64String(GetBase64());
        }
    }
}