using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using NicaBiometrics.Properties;
using zkemkeeper;

namespace NicaBiometrics.models
{
    internal class DeviceSetting
    {
        private readonly CZKEM _czkem;

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

        private void SetMacAddress()
        {
            string macAddresss = null;
            _czkem.GetDeviceMAC(Settings.Default._machineNo, ref macAddresss);
            Settings.Default._macAddress = macAddresss;
        }


        private void SetSerial()
        {
            _czkem.GetSerialNumber(Settings.Default._machineNo, out var serialNumber);
            Settings.Default._serialNumber = serialNumber;
        }

        private void SetBiometricType()
        {
            String type = GetSystemOption("BiometricType");
            Settings.Default._biometricType = type;
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
            return IPAddress.TryParse(Settings.Default._deviceIpAddress, out var IpAdd);
        }

        public void ConnectViaNet(List<string> messages)
        {
            if (ValidateIpAddress())
            {
                var port = Settings.Default._devicePort;

                if (port <= 0 || port > 65535) messages.Add(Resources.LABEL_ILLEGAL_PORT);

                var iCommkey = Convert.ToInt32(Settings.Default._commKey);
                _czkem.SetCommPassword(iCommkey);
                if (Settings.Default._connected)
                {
                    _czkem.Disconnect();
                    UnRegisterEvents();
                    SetConnected(false);
                    messages.Add(WriteLog(Resources.LABEL_DISCONNECT_WITH_DEVICE));
                }

                if (_czkem.Connect_Net(Settings.Default._deviceIpAddress,
                    Settings.Default._devicePort))
                {
                    RegisterEvents(messages);
                    SetConnected(true);
                    messages.Add(WriteLog(Resources.LABEL_DEVICE_CONNECTED));
                }
                else
                {
                    var idwErrorCode = 0;
                    _czkem.GetLastError(ref idwErrorCode);
                    messages.Add(WriteLog(Resources.LABEL_UNABLE_TO_CONNECT_VIA_NET + idwErrorCode));
                }
            }
            else
            {
                messages.Add(WriteLog(Resources.LABEL_INVALID_DEVICE_IP_ADDRESS));
            }
        }

        public void ConnectViaUsb(List<string> messages)
        {
            try
            {
                if (Convert.ToInt32(Settings.Default._deviceId) < 0 ||
                    Convert.ToInt32(Settings.Default._deviceId) > 256)
                {
                    messages.Add(WriteLog(Resources.LABEL_ILLEGAL_DEVICE));
                    return;
                }
            }
            catch (FormatException)
            {
                messages.Add(WriteLog(Resources.LABEL_ILLEGAL_DEVICE));
                return;
            }

            var idwErrorCode = 0;
            var iPort = 0;
            var iBaudrate = 115200;
            var iDeviceId = Convert.ToInt32(Settings.Default._deviceId);
            var iCommkey = Convert.ToInt32(Settings.Default._commKey);
            var sCom = Settings.Default._usbDevice;

            for (iPort = 1; iPort < 10; iPort++)
                if (sCom.IndexOf(iPort.ToString(), StringComparison.Ordinal) > -1)
                    break;

            _czkem.SetCommPassword(iCommkey);
            if (Settings.Default._connected)
            {
                _czkem.Disconnect();
                UnRegisterEvents();
                SetConnected(false);
                messages.Add(WriteLog(Resources.LABEL_DISCONNECT_WITH_DEVICE));
            }

            if (_czkem.Connect_Com(iPort, iDeviceId, iBaudrate))
            {
                RegisterEvents(messages);
                SetConnected(true);
                messages.Add(WriteLog(Resources.LABEL_DEVICE_CONNECTED));
            }
            else
            {
                _czkem.GetLastError(ref idwErrorCode);
                messages.Add(WriteLog(Resources.LABEL_UNABLE_TO_CONNECT_VIA_USB + idwErrorCode));
            }
        }

        public void Connect(out List<string> messages)
        {
            messages = new List<string>();

            var deviceid = Settings.Default._deviceId;
            var commkey = Settings.Default._commKey;

            if (deviceid == "" || commkey == "")
            {
                messages.Add(WriteLog(Resources.LABEL_COMM_KEY_REQUIRED));
                return;
            }

            try
            {
                if (Convert.ToInt32(commkey) < 0 || Convert.ToInt32(commkey) > 999999)
                {
                    messages.Add(WriteLog(Resources.LABEL_ILLEGAL_COMMKEY));
                    return;
                }
            }
            catch (FormatException)
            {
                messages.Add(WriteLog(Resources.LABEL_ILLEGAL_COMMKEY));
                return;
            }

            if (Settings.Default._connectViaNet)
                ConnectViaNet(messages);
            else if (Settings.Default._connectViaUSB) ConnectViaUsb(messages);


            SetSerial();
            SetMacAddress();
            SetBiometricType();
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }

        public void Disconnect()
        {
            if (Settings.Default._connected)
            {
                _czkem.Disconnect();
                UnRegisterEvents();
                SetConnected(false);
            }
        }

        private void RegisterEvents(List<string> messages)
        {
            if (_czkem.RegEvent(Settings.Default._machineNo, 65535))
            {
                _czkem.OnFinger += HandleOnFinger;
                messages.Add(Resources.LABEL_REGISTERED_EVENTS);
            }
            else
            {
                var idwErrorCode = 0;
                _czkem.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                    messages.Add(Resources.LABEL_REG_EVENT_FAILED + idwErrorCode);
                else
                    messages.Add(Resources.LABEL_NO_DATA_TERMINAL);
            }
        }

        private void UnRegisterEvents()
        {
            _czkem.OnFinger -= HandleOnFinger;
            _czkem.OnFingerFeature -= HandleOnFingerFeature;
        }

        public void HandleOnFinger()
        {
            Console.WriteLine("Fingered");
        }

        private void HandleOnFingerFeature(int findgerId)
        {
            Console.WriteLine("finger" + findgerId);
        }

        public void Restart()
        {
            SetConnected(false);
            _czkem.RestartDevice(Settings.Default._machineNo);
        }

        private string GetSystemOption(string option)
        {
            string value = string.Empty;
            _czkem.GetSysOption(Settings.Default._machineNo, option, out value);
            return value;
        }
    }
}