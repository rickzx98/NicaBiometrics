using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace NicaBiometrics.models
{
    class UsbDeviceInfo
    {
        private readonly string _deviceName;
        private readonly string _pnpDeviceId;
        private readonly string _description;

        private UsbDeviceInfo(string deviceName, string pnpDeviceId, string description)
        {
            this._deviceName = deviceName;
            this._pnpDeviceId = pnpDeviceId;
            this._description = description;
        }

        public string GetDeviceName()
        {
            return _deviceName;
        }

        public string GetPnpDeviceId()
        {
            return _pnpDeviceId;
        }

        public string GetDescription()
        {
            return _description;
        }

        public static List<UsbDeviceInfo> GetCurrentUsbDeviceInfos()
        {
            List<UsbDeviceInfo> devices = new List<UsbDeviceInfo>();
            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();
            foreach (var device in collection)
            {
                UsbDeviceInfo usbDevice = new UsbDeviceInfo(device.GetPropertyValue("DeviceID").ToString(),
                    device.GetPropertyValue("PNPDeviceID").ToString(),
                    device.GetPropertyValue("Description").ToString());
                devices.Add(usbDevice);
            }

            return devices;
        }
    }
}