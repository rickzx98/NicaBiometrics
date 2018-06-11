using System;
using System.Collections.Generic;
using System.Net;
using NicaBiometrics.Properties;
using zkemkeeper;

namespace NicaBiometrics.models
{
    internal class DeviceSetting
    {
        private const int CheckedIn = 0;
        private const int CheckedOut = 1;
        private const int OvertimeIn = 4;
        private const int OvertimeOut = 5;
        private const int VerfiyFingerprint = 1;
        private static CZKEM _czkem;
        private readonly TimeReport _timeReport;

        public DeviceSetting()
        {
            if (_czkem == null)
                _czkem = new CZKEM();
            _timeReport = new TimeReport();
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
            var type = GetSystemOption("BiometricType");
            Settings.Default._biometricType = type;
        }

        private void SetDeviceName()
        {
            _czkem.GetProductCode(Settings.Default._machineNo, out var sDeviceName);
            Settings.Default._deviceName = sDeviceName;
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
            return IPAddress.TryParse(Settings.Default._deviceIpAddress, out var ipAdd);
        }

        public void ConnectViaNet(List<string> messages)
        {
            if (ValidateIpAddress())
            {
                Settings.Default._machineNo = 1;
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
               // UnRegisterEvents();
                SetConnected(false);
                messages.Add(WriteLog(Resources.LABEL_DISCONNECT_WITH_DEVICE));
            }

            if (_czkem.Connect_Com(iPort, iDeviceId, iBaudrate))
            {
              //  RegisterEvents(messages);
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

            if (deviceid == "" || commkey == "") messages.Add(WriteLog(Resources.LABEL_COMM_KEY_REQUIRED));

            try
            {
                if (Convert.ToInt32(commkey) < 0 || Convert.ToInt32(commkey) > 999999)
                    messages.Add(WriteLog(Resources.LABEL_ILLEGAL_COMMKEY));
            }
            catch (FormatException)
            {
                messages.Add(WriteLog(Resources.LABEL_ILLEGAL_COMMKEY));
            }

            if (Settings.Default._connectViaNet)
                ConnectViaNet(messages);
            else if (Settings.Default._connectViaUSB) ConnectViaUsb(messages);
            SetSerial();
            SetMacAddress();
            SetBiometricType();
            SetDeviceName();
        }

        private string WriteLog(string log)
        {
            return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": " + log;
        }

        public void Disconnect()
        {
            if (Settings.Default._connected)
            {
                SetConnected(false);
                _czkem.Disconnect();
                UnRegisterEvents();
                _czkem.EnableDevice(Settings.Default._machineNo, false);
            }
        }

        private void RegisterEvents(List<string> messages)
        {
            _czkem.EnableDevice(Settings.Default._machineNo, Settings.Default._connected);
            if (_czkem.RegEvent(Settings.Default._machineNo, 65535))
            {
                // no fn events really worked
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
            // no fn events working
        }

        public void Restart()
        {
            SetConnected(false);
            _czkem.RestartDevice(Settings.Default._machineNo);
        }

        private string GetSystemOption(string option)
        {
            var value = string.Empty;
            _czkem.GetSysOption(Settings.Default._machineNo, option, out value);
            return value;
        }

        public void SendNewLog(out List<string> messages, out bool found)
        {
            messages = new List<string>();
            found = false;
            var dwWorkCode = 0;
            try
            {
                if (Settings.Default._connected)
                {
                    _czkem.ReadGeneralLogData(Settings.Default._machineNo);

                    found = _czkem.SSR_GetGeneralLogData(Settings.Default._machineNo,
                        out var dwEnrollNumber,
                        out _,
                        out var dwInOutMode,
                        out _,
                        out _,
                        out _,
                        out _,
                        out _,
                        out _,
                        ref dwWorkCode);

                    if (found && !string.IsNullOrEmpty(dwEnrollNumber))

                    {
                        switch (dwInOutMode)
                        {
                            case OvertimeIn:
                            case CheckedIn:
                                _timeReport.TimeIn(dwEnrollNumber, out var messageList0);
                                messages = messageList0;
                                break;
                            case CheckedOut:
                            case OvertimeOut:
                                _timeReport.TimeOut(dwEnrollNumber, out var messageList1);
                                messages = messageList1;
                                break;
                        }

                        _czkem.ClearGLog(Settings.Default._machineNo);
                    }
                }
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
            }
        }

        public void LoadEnrolledEmployees(out List<Employees.Employee> employees, out List<string> messages)
        {
            employees = new List<Employees.Employee>();
            messages = new List<string>();
            try
            {
                _czkem.ReadAllUserID(Settings.Default._machineNo);
                while (_czkem.SSR_GetAllUserInfo(Settings.Default._machineNo, out var dwEnrollNumber, out var name,
                    out var password, out var privelage,
                    out var enabled))
                    employees.Add(new Employees.Employee(int.Parse(dwEnrollNumber), int.Parse(password), name));

                messages.Add(Resources.MESSAGE_LOADED_ALL_EMPLOYEES);
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
            }
        }

        public void EnrollEmployee(Employees.Employee employee, out List<string> messages, out bool enrolled)
        {
            messages = new List<string>();
            enrolled = false;
            try
            {
                enrolled = _czkem.SSR_SetUserInfo(Settings.Default._machineNo, employee.Id.ToString(),
                    employee.FullName,
                    employee.Pin.ToString(),
                    0, true);
                messages.Add(enrolled
                    ? WriteLog(Resources.MESSAGE_ENROLLED_USER + employee.FullName)
                    : WriteLog(Resources.FAILED_TO_ENROLL + employee.FullName));
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
            }
        }

        public void DeleteEnrolledEmployee(Employees.Employee employee, out List<string> messages, out bool deleted)
        {
            messages = new List<string>();
            deleted = false;
            try
            {
                deleted = _czkem.SSR_DeleteEnrollData(Settings.Default._machineNo, employee.Id.ToString(), 12);
                messages.Add(deleted
                    ? WriteLog(Resources.MESSAGE_REMOVED_USER + employee.FullName)
                    : WriteLog(Resources.MESSAGE_UNABLE_TO_REMOVE_USER + employee.FullName));
            }
            catch (Exception e)
            {
                messages.Add(WriteLog(e.Message));
            }
        }
    }
}