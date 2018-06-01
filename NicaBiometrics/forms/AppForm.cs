using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using NicaBiometrics.helper;
using NicaBiometrics.models;
using NicaBiometrics.Properties;

namespace NicaBiometrics.forms
{
    public partial class TRAY_FORM : Form
    {
        private readonly DeviceSetting _deviceSetting;
        private readonly ServerSetting _serverSetting;
        private List<string> _messages;
        private bool _shutdown;

        public TRAY_FORM()
        {
            _shutdown = false;
            _deviceSetting = new DeviceSetting();
            _serverSetting = new ServerSetting();
            InitializeComponent();
        }

        private void ShowTrayIcon()
        {
            Hide();
            APP_TRAY_ICON.ShowBalloonTip(1000, Resources.LABEL_APP_NAME, Resources.LABEL_APPLICATION_RUNNING_BACKGROUND,
                ToolTipIcon.Info);
        }

        private void Connect(object sender)
        {
            Connect();
            if (_deviceSetting.IsConnected())
            {
                var connect = (Button) sender;
                connect.Enabled = false;
            }
            else
            {
                MessageBox.Show(Resources.LABEL_DEVICE_CONNECTION_FAILED, Resources.LABEL_APP_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUTTON_REFRESH_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void VALUE_DEVICE_ADDRESS_TextChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var textBox = (TextBox) sender;
                _deviceSetting.SetIpAddress(textBox.Text);
            }
        }

        private void VALUE_DEVICE_PORT_TextChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var textBox = (TextBox) sender;
                if (textBox.Text != "")
                    _deviceSetting.SetPort(int.Parse(textBox.Text));
                else
                    _deviceSetting.SetPort(0);
            }
        }

        private void BUTTON_CONNECT_Click(object sender, EventArgs e)
        {
            Connect(sender);
        }

        private void TRAY_FORM_Move(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) ShowTrayIcon();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shutdown = true;
            Application.Exit();
        }

        private void APP_TRAY_ICON_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void TRAY_FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            if (!_shutdown)
            {
                if (e.CloseReason == CloseReason.WindowsShutDown) return;
                e.Cancel = true;
                ShowTrayIcon();
            }
            else
            {
                switch (MessageBox.Show(Resources.LABEL_CONFIRM_EXIT, Resources.LABEL_APP_NAME, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        e.Cancel = false;
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void APP_CONTEXT_MENU_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void TRAY_FORM_Load(object sender, EventArgs e)
        {
            CHECK_VIA_NET.Checked = Settings.Default._connectViaNet;
            CHECK_VIA_USB.Checked = Settings.Default._connectViaUSB;
            VALUE_DEVICE_ID.Text = Settings.Default._deviceId;
            VALUE_COMM_KEY.Text = Settings.Default._commKey;
            BUTTON_DEVICE_REFRESH.Enabled = Settings.Default._connected;
            BUTTON_CONNECT.Enabled = !Settings.Default._connected;
            LoadConsoleLogs();
            RefreshDeviceSettingNet();
            RefreshDeviceSettingUsb();
            Connect();
        }

        private void LoadConsoleLogs()
        {
            if (Settings.Default._consoleLogs != null)
            {
                LIST_DEVICE_HARDWARE.Items.Clear();
                foreach (var consoleLog in Settings.Default._consoleLogs)
                {
                    LIST_DEVICE_HARDWARE.Items.Add(consoleLog);
                }
            }
        }

        private void BUTTON_CONNECT_SERVER_Click(object sender, EventArgs e)
        {
            _serverSetting.Connect();
        }

        private void VALUE_SERVER_ADDRESS_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            _serverSetting.SetIpAddress(textBox.Text);
        }

        private void CHECK_VIA_NET_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox) sender;
            Settings.Default._connectViaNet = checkBox.Checked;
            RefreshDeviceSettingNet();
            RefreshDeviceSettingUsb();
        }

        private void RefreshDeviceSettingNet()
        {
            CHECK_VIA_NET.Enabled = !Settings.Default._connectViaUSB;
            CHECK_VIA_NET.Checked = Settings.Default._connectViaNet;
            VALUE_DEVICE_PORT.Enabled = Settings.Default._connectViaNet;
            VALUE_DEVICE_ADDRESS.Enabled = Settings.Default._connectViaNet;
            VALUE_DEVICE_ADDRESS.Text = Settings.Default._deviceIpAddress;
            VALUE_DEVICE_PORT.Text = Settings.Default._devicePort.ToString();
            BUTTON_CONNECT.Enabled = Settings.Default._connectViaNet;
            BUTTON_DEVICE_REFRESH.Enabled = Settings.Default._connectViaNet && Settings.Default._connected;
        }

        private void CHECK_VIA_USB_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox) sender;
            Settings.Default._connectViaUSB = checkBox.Checked;
            RefreshDeviceSettingUsb();
            RefreshDeviceSettingNet();
        }

        private void RefreshDeviceSettingUsb()
        {
            CHECK_VIA_USB.Enabled = !Settings.Default._connectViaNet;
            CHECK_VIA_USB.Checked = Settings.Default._connectViaUSB;
            BUTTON_REFRESH_USB_LIST.Enabled = Settings.Default._connectViaUSB;
            VALUE_DEVICE_ID.Enabled = Settings.Default._connectViaUSB;
        }

        private void BUTTON_REFRESH_USB_LIST_Click(object sender, EventArgs e)
        {
            string device = null;
            var found = new SearchforUsbCom().SearchforCom(ref device);
            if (!found)
                MessageBox.Show(Resources.LABEL_NO_USB_DEVICE_FOUND, Resources.LABEL_APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else
            {
                Settings.Default._usbDevice = device;
                Connect();
            }
        }

        private void Connect()
        {
            if (Settings.Default._connectViaUSB && Settings.Default._usbDevice == null)
            {
                MessageBox.Show(Resources.LABEL_NO_USB_DEVICE_FOUND, Resources.LABEL_APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            using (var deviceProgress = new ConnectingToDeviceProcessForm(ConnectDevice))
            {
                deviceProgress.ShowDialog(this);
            }

            foreach (var message in _messages)
            {
                if (Settings.Default._consoleLogs == null)
                {
                    Settings.Default._consoleLogs = new StringCollection();
                }

                Settings.Default._consoleLogs.Add(message);
                LIST_DEVICE_HARDWARE.Items.Add(message);
            }
        }

        private void ConnectDevice()
        {
            _deviceSetting.Connect(out var messages);
            _messages = messages;
        }


        private void VALUE_COMM_KEY_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            _deviceSetting.SetCommKey(textBox.Text);
        }

        private void VALUE_DEVICE_ID_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            _deviceSetting.SetDeviceId(textBox.Text);
        }

        private void BUTTON_CLEAR_LOGS_Click(object sender, EventArgs e)
        {
            LIST_DEVICE_HARDWARE.Items.Clear();
            Settings.Default._consoleLogs.Clear();
        }

        private void APP_CONTEXT_MENU_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}