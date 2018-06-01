using System;
using System.Collections.Generic;
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
            _deviceSetting.Connect(out var message);
            if (_deviceSetting.IsConnected())
            {
                var connect = (Button) sender;
                connect.Enabled = false;
            }
            else
            {
                MessageBox.Show(message, Resources.LABEL_APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUTTON_REFRESH_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
            RefreshDeviceSettingNet();
            RefreshDeviceSettingUsb();
            RenderUsbDeviceList();
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
            BUTTON_DEVICE_REFRESH.Enabled = Settings.Default._connectViaNet;
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
            LIST_DEVICE_USB_HARDWARE.Enabled = Settings.Default._connectViaUSB;
            BUTTON_REFRESH_USB_LIST.Enabled = Settings.Default._connectViaUSB;
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
                RenderUsbDeviceList();
            }
        }

        private void RenderUsbDeviceList()
        {
            if (Settings.Default._usbDevice != null)
            {
                LIST_DEVICE_USB_HARDWARE.Items.Clear();
                string deviceid = Settings.Default._deviceId;
                string commkey = Settings.Default._commKey;

                if (deviceid == "" || commkey == "")
                {
                    LIST_DEVICE_USB_HARDWARE.Items.Add(Resources.LABEL_COMM_KEY_REQUIRED);
                    return;
                }

                if (Convert.ToInt32(deviceid) < 0 || Convert.ToInt32(deviceid) > 256)
                {
                    LIST_DEVICE_USB_HARDWARE.Items.Add(Resources.LABEL_ILLEGAL_DEVICE);
                    return;
                }

                if (Convert.ToInt32(commkey) < 0 || Convert.ToInt32(commkey) > 999999)
                {
                    LIST_DEVICE_USB_HARDWARE.Items.Add(Resources.LABEL_ILLEGAL_COMMKEY);
                    return;
                }

                SetUsbSettingFieldState(false);
                using (var deviceProgress = new ConnectingToDeviceProcessForm(ConnectViaUsb))
                {
                    deviceProgress.ShowDialog(this);
                }

                foreach (var message in _messages)
                {
                    LIST_DEVICE_USB_HARDWARE.Items.Add(message);
                }

            }
            else
            {
                MessageBox.Show(Resources.LABEL_NO_USB_DEVICE_FOUND, Resources.LABEL_APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }

            SetUsbSettingFieldState(true);
        }

        private void ConnectViaUsb()
        {
            _deviceSetting.ConnectViaUsb(out var messages);
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

        private void SetUsbSettingFieldState(bool state)
        {
            BUTTON_REFRESH_USB_LIST.Enabled = state;
            CHECK_VIA_USB.Enabled = state;
            VALUE_COMM_KEY.Enabled = state;
            VALUE_DEVICE_ID.Enabled = state;
        }
    }
}