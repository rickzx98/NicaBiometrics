using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicaBiometrics.forms
{
    public partial class ConnectingToDeviceProcessForm : Form
    {
        public Action Worker { get; set; }

        public ConnectingToDeviceProcessForm(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
        }

        protected override void OnLoad(EventArgs e)
        {
            Application.EnableVisualStyles();
            base.OnLoad(e);
            TIMER_PROGRESS_TICK.Start();
            Task.Factory.StartNew(Worker)
                .ContinueWith(t =>
                {
                    TIMER_PROGRESS_TICK.Stop();
                    this.Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void TIMER_PROGRESS_TICK_Tick(object sender, EventArgs e)
        {
            if (PROGRESS_CONNECTING_TO_DEVICE.Value == 100)
            {
                PROGRESS_CONNECTING_TO_DEVICE.Value = 0;
            }

            PROGRESS_CONNECTING_TO_DEVICE.Increment(1);
        }
    }
}