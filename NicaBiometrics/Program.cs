using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using NicaBiometrics.forms;
using NicaBiometrics.Properties;
using zkemkeeper;

namespace NicaBiometrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread singleThreadedApplication = new Thread(() =>
            {
                Application.Run(new TRAY_FORM());
            });
            singleThreadedApplication.SetApartmentState(ApartmentState.MTA);
            singleThreadedApplication.Start();
        }
    }
}