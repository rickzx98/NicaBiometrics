using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NicaBiometrics.helper
{
    class SearchforUsbCom
    {
        //Search for the virtual serial port created by usbclient.
        public bool SearchforCom(ref string sCom) //modify by Darcy on Nov.26 2009
        {
            RegistryKey myReg = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\SERIALCOMM");
            if (myReg != null)
            {
                string[]
                    sComNames = myReg
                        .GetValueNames(); //strings array composed of the key name holded by the subkey "SERIALCOMM"
                foreach (var comName in sComNames)
                {
                    string sComValue = "";
                    sComValue = myReg.GetValue(comName)
                        .ToString(); //obtain the key value of the corresponding key name
                    if (sComValue == "")
                    {
                        continue;
                    }

                    sCom = "";
                    if (comName == "\\Device\\USBSER000") //find the virtual serial port created by usbclient
                    {
                        for (int j = 0; j <= 10; j++)
                        {
                            string sTmpara = "";
                            RegistryKey myReg2 = Registry.LocalMachine.OpenSubKey(
                                @"SYSTEM\CurrentControlSet\Enum\USB\VID_1B55&PID_B400\" + j.ToString() +
                                @"\Device Parameters"); //find the plug and play USB device
                            if (myReg2 != null) //add by Darcy on Nov.26 2009
                            {
                                sTmpara = myReg2.GetValue("PortName").ToString();

                                if (sComValue == sTmpara)
                                {
                                    sCom = sTmpara;
                                    return true; //add by Darcy on Nov.26 2009
                                }
                            }
                        }
                    }
                }
            }

            return false; //add by Darcy on Nov.26 2009
        }
    }
}