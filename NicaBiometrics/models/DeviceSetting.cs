using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using NicaBiometrics.Properties;
using zkemkeeper;

namespace NicaBiometrics.models
{
    internal class DeviceSetting
    {
        private readonly CZKEM _czkem;
        private bool _connected;

        public DeviceSetting()
        {
            _czkem = new CZKEM();
        }

        public void SetIpAddress(string ipAddress)
        {
            Settings.Default._deviceIpAddress = ipAddress;
        }

        public void SetPort(int port)
        {
            Settings.Default._devicePort = port;
        }


        public void SetUsbDevice(string usbDevice)
        {
            Settings.Default._usbDevice = usbDevice;
        }

        public void SetCommKey(string commKey)
        {
            Settings.Default._commKey = commKey;
        }

        public void SetDeviceId(string deviceId)
        {
            Settings.Default._deviceId = deviceId;
        }

        public void SetConnected(bool connected)
        {
            Settings.Default._connected = connected;
        }

        public bool ValidateIpAddress()
        {
            IPAddress IpAdd;
            return IPAddress.TryParse(Settings.Default._deviceIpAddress, out IpAdd);
        }

        public bool IsConnected()
        {
            return _connected;
        }

        public void ConnectViaNet(List<string> messages)
        {
            if (ValidateIpAddress())
            {
                int port = Settings.Default._devicePort;

                if (port <= 0 || port > 65535)
                {
                    messages.Add(Resources.LABEL_ILLEGAL_PORT);
                }

                int iCommkey = Convert.ToInt32(Settings.Default._commKey);
                _czkem.SetCommPassword(iCommkey);
                if (Settings.Default._connected)
                {
                    _czkem.Disconnect();
                    // un reg all events
                    SetConnected(false);
                    messages.Add(Resources.LABEL_DISCONNECT_WITH_DEVICE);
                }

                if (_czkem.Connect_Net(Settings.Default._deviceIpAddress,
                    Settings.Default._devicePort))
                {
                    SetConnected(true);
                    messages.Add(Resources.LABEL_DEVICE_CONNECTED);
                }
                else
                {
                    int idwErrorCode = 0;
                    _czkem.GetLastError(ref idwErrorCode);
                    messages.Add(Resources.LABEL_UNABLE_TO_CONNECT_VIA_NET + idwErrorCode);
                }
            }
            else
            {
                messages.Add(Resources.LABEL_INVALID_DEVICE_IP_ADDRESS);
            }
        }

        public void ConnectViaUsb(List<string> messages)
        {
            try
            {
                if (Convert.ToInt32(Settings.Default._deviceId) < 0 ||
                    Convert.ToInt32(Settings.Default._deviceId) > 256)
                {
                    messages.Add(Resources.LABEL_ILLEGAL_DEVICE);
                    return;
                }
            }
            catch (FormatException)
            {
                messages.Add(Resources.LABEL_ILLEGAL_DEVICE);
                return;
            }

            int idwErrorCode = 0;
            int iPort = 0;
            int iBaudrate = 115200;
            int iDeviceId = Convert.ToInt32(Settings.Default._deviceId);
            int iCommkey = Convert.ToInt32(Settings.Default._commKey);
            string sCom = Properties.Settings.Default._usbDevice;

            for (iPort = 1; iPort < 10; iPort++)
            {
                if (sCom.IndexOf(iPort.ToString(), StringComparison.Ordinal) > -1)
                {
                    break;
                }
            }

            _czkem.SetCommPassword(iCommkey);
            if (Settings.Default._connected)
            {
                _czkem.Disconnect();
                // un reg all events
                SetConnected(false);
                messages.Add(Resources.LABEL_DISCONNECT_WITH_DEVICE);
            }

            if (_czkem.Connect_Com(iPort, iDeviceId, iBaudrate))
            {
                SetConnected(true);
                messages.Add(Resources.LABEL_DEVICE_CONNECTED);
            }
            else
            {
                _czkem.GetLastError(ref idwErrorCode);
                messages.Add(Resources.LABEL_UNABLE_TO_CONNECT_VIA_USB + idwErrorCode);
            }
        }

        public void Connect(out List<string> messages)
        {
            messages = new List<string>();

            string deviceid = Settings.Default._deviceId;
            string commkey = Settings.Default._commKey;

            if (deviceid == "" || commkey == "")
            {
                messages.Add(Resources.LABEL_COMM_KEY_REQUIRED);
                return;
            }

            try
            {
                if (Convert.ToInt32(commkey) < 0 || Convert.ToInt32(commkey) > 999999)
                {
                    messages.Add(Resources.LABEL_ILLEGAL_COMMKEY);
                    return;
                }
            }
            catch (FormatException)
            {
                messages.Add(Resources.LABEL_ILLEGAL_COMMKEY);
                return;
            }

            if (Settings.Default._connectViaNet)
            {
                ConnectViaNet(messages);
            }
            else if (Settings.Default._connectViaUSB)
            {
                ConnectViaUsb(messages);
            }
        }
    }
}