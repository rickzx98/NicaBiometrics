using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NicaBiometrics.Properties;

namespace NicaBiometrics.forms
{
    public partial class ConnectingToDeviceProcessForm : Form
    {
        public ConnectingToDeviceProcessForm(Action worker)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
        }

        public ConnectingToDeviceProcessForm(Action worker, string message)
        {
            InitializeComponent();
            Worker = worker ?? throw new ArgumentNullException();
            Message = message ?? Resources.LABEL_CONNECTING_TO_DEVICE;
        }

        public Action Worker { get; set; }
        public string Message { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            Application.EnableVisualStyles();
            base.OnLoad(e);
            TIMER_PROGRESS_TICK.Start();
            if (Message != null) LABEL_CONNECTING_TO_DEVICE.Text = Message;
            Task.Factory.StartNew(Worker)
                .ContinueWith(t =>
                {
                    TIMER_PROGRESS_TICK.Stop();
                    Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void TIMER_PROGRESS_TICK_Tick(object sender, EventArgs e)
        {
            if (PROGRESS_CONNECTING_TO_DEVICE.Value == 100) PROGRESS_CONNECTING_TO_DEVICE.Value = 0;

            PROGRESS_CONNECTING_TO_DEVICE.Increment(1);
        }
    }
}