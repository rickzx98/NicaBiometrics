using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Forms;
using NicaBiometrics.helper;
using NicaBiometrics.models;
using NicaBiometrics.Properties;

namespace NicaBiometrics.forms
{
    public partial class TRAY_FORM : Form
    {
        private readonly Companies _companies;
        private readonly DeviceSetting _deviceSetting;
        private readonly Employees _employees;
        private readonly ServerSetting _serverSetting;
        private List<Companies.Company> _companyList;
        private List<Employees.Employee> _employeeList;
        private List<string> _messages;
        private List<string> _serverMessages;
        private bool _shutdown;
        private bool _timeInProgress;

        public TRAY_FORM()
        {
            _shutdown = false;
            _deviceSetting = new DeviceSetting();
            _serverSetting = new ServerSetting();
            _employees = new Employees(_deviceSetting);
            _companies = new Companies();
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
            if (Settings.Default._connected)
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
            Close();
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
                        new ConnectingToDeviceProcessForm(() => { _deviceSetting.Disconnect(); },
                            Resources.LABEL_DISCONNECTING_DEVICE).ShowDialog(this);
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
            }
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
            ConnectServer();
            RefreshServerSettingComponents();
            RefreshServerLogs();
            LoadCompanies();
            LoadEmployees();
        }

        private void LoadConsoleLogs()
        {
            if (Settings.Default._consoleLogs != null)
            {
                LIST_DEVICE_HARDWARE.Items.Clear();
                foreach (var consoleLog in Settings.Default._consoleLogs) LIST_DEVICE_HARDWARE.Items.Add(consoleLog);
            }

            if (Settings.Default._serverLogs != null)
            {
                LIST_SERVER_LOGS.Items.Clear();
                foreach (var serverLog in Settings.Default._serverLogs) LIST_SERVER_LOGS.Items.Add(serverLog);
            }
        }

        private void BUTTON_CONNECT_SERVER_Click(object sender, EventArgs e)
        {
            new ConnectingToDeviceProcessForm(ConnectServer, Resources.LABEL_ESTABLISHING_SERVER_CONNECTION)
                .ShowDialog(this);
            RefreshServerSettingComponents();
            RefreshServerLogs();
        }

        private void VALUE_SERVER_ADDRESS_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            _serverSetting.SetServerAddress(textBox.Text);
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
            {
                MessageBox.Show(Resources.LABEL_NO_USB_DEVICE_FOUND, Resources.LABEL_APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
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

            if (Settings.Default._consoleLogs == null) Settings.Default._consoleLogs = new StringCollection();

            foreach (var message in _messages)
            {
                Settings.Default._consoleLogs.Add(message);
                LIST_DEVICE_HARDWARE.Items.Add(message);
            }

            if (Settings.Default._connected)
            {
                RefreshRemoteControl();
                TIME_LISTENER_LOG.Start();
                if (!TAB_FORM_TRAY.Controls.Contains(TAB_REMOTE_CONTROL))
                    TAB_FORM_TRAY.Controls.Add(TAB_REMOTE_CONTROL);
            }
            else
            {
                TAB_FORM_TRAY.Controls.Remove(TAB_REMOTE_CONTROL);
            }
        }

        private void ConnectDevice()
        {
            _deviceSetting.Connect(out _messages);
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
            Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void BUTTON_RESTART_Click(object sender, EventArgs e)
        {
            new ConnectingToDeviceProcessForm(() => { _deviceSetting.Restart(); }, Resources.LABEL_RESTARTING_DEVICE)
                .ShowDialog(this);
        }

        private void RefreshRemoteControl()
        {
            VALUE_SERIAL.Text = Settings.Default._serialNumber;
            VALUE_MAC_ADD.Text = Settings.Default._macAddress;
            VALUE_BIOTMETRIC_TYPE.Text = Settings.Default._biometricType;
            VALUE_DEVICE_NAME.Text = Settings.Default._deviceName;
        }

        private void TIME_LISTENER_LOG_Tick(object sender, EventArgs e)
        {
            var messageList = new List<string>();
            if (Settings.Default._connected && !_timeInProgress)
            {
                _timeInProgress = true;
                Task.Factory.StartNew(() =>
                {
                    _deviceSetting.SendNewLog(out var messages);
                    messageList = messages;
                }).ContinueWith(t =>
                {
                    messageList.ForEach(message =>
                    {
                        LIST_DEVICE_HARDWARE.Items.Add(message);
                        Settings.Default._consoleLogs.Add(message);
                    });
                    _timeInProgress = false;
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void ConnectServer()
        {
            _serverSetting.Connect(out var messages);
            _serverMessages = messages;
        }

        private void RefreshServerSettingComponents()
        {
            VALUE_SERVER_ADDRESS.Text = Settings.Default._serverAddress;
            VALUE_TIMEIN_URL.Text = Settings.Default._serverTimeinUrl;
            VALUE_TIMEOUT_URL.Text = Settings.Default._serverTimeoutUrl;
            VALUE_EMPLOYEE_URL.Text = Settings.Default._serverEmployeeUrl;
            VALUE_COMPANY_URL.Text = Settings.Default._serverCompanyUrl;
            BUTTON_CONNECT_SERVER.Enabled = !Settings.Default._connectedServer;
            BUTTON_REFRESH_SERVER.Enabled = Settings.Default._connectedServer;
            VALUE_TIMEIN_URL.Enabled = Settings.Default._connectedServer;
            VALUE_TIMEOUT_URL.Enabled = Settings.Default._connectedServer;
            VALUE_EMPLOYEE_URL.Enabled = Settings.Default._connectedServer;
            VALUE_COMPANY_URL.Enabled = Settings.Default._connectedServer;
            if (Settings.Default._connectedServer && !string.IsNullOrWhiteSpace(Settings.Default._serverCompanyUrl))
            {
                if (!TAB_FORM_TRAY.Controls.Contains(TAB_COMPANY)) TAB_FORM_TRAY.Controls.Add(TAB_COMPANY);
            }

            else
            {
                TAB_FORM_TRAY.Controls.Remove(TAB_COMPANY);
            }
        }

        private void BUTTON_REFRESH_SERVER_Click(object sender, EventArgs e)
        {
            new ConnectingToDeviceProcessForm(ConnectServer, Resources.LABEL_REFRESHING_SERVER_CONNECTION)
                .ShowDialog(this);
            RefreshServerSettingComponents();
            RefreshServerLogs();
        }

        private void RefreshServerLogs()
        {
            foreach (var log in _serverMessages)
            {
                if (Settings.Default._serverLogs == null) Settings.Default._serverLogs = new StringCollection();

                Settings.Default._serverLogs.Add(log);
                LIST_SERVER_LOGS.Items.Add(log);
            }
        }

        private void BUTTON_CLEAR_SERVER_LOGS_Click(object sender, EventArgs e)
        {
            if (Settings.Default._serverLogs != null) Settings.Default._serverLogs.Clear();
            LIST_SERVER_LOGS.Items.Clear();
        }

        private void VALUE_TIMEIN_URL_TextChanged(object sender, EventArgs e)
        {
            _serverSetting.SetTimeInUrl(((TextBox) sender).Text);
        }

        private void VALUE_TIMEOUT_URL_TextChanged(object sender, EventArgs e)
        {
            _serverSetting.SetTimeOutUrl(((TextBox) sender).Text);
        }

        private void VALUE_EMPLOYEE_URL_TextChanged(object sender, EventArgs e)
        {
            _serverSetting.SetEmployeeUrl(((TextBox) sender).Text);
        }

        private void BUTTON_ADD_COMPANY_Click(object sender, EventArgs e)
        {
            new CompaniesDialog(companies =>
            {
                _companyList = companies;
                SetCompanies();
                _companies.Save(_companyList);
            }).ShowDialog(this);
        }

        private void SetCompanies()
        {
            LIST_COMPANIES.DataSource = _companyList;
            LIST_COMPANIES.ValueMember = "IsChecked";
            LIST_COMPANIES.DisplayMember = "Name";
            SELECT_COMPANIES.DataSource = _companyList;
            SELECT_COMPANIES.DisplayMember = "Name";
            SELECT_COMPANIES.ValueMember = "Id";
            RefreshTabEmployee();
        }

        private void BUTTON_REMOVE_COMPANY_Click(object sender, EventArgs e)
        {
            _companyList = new List<Companies.Company>(_companyList);
            foreach (Companies.Company checkedItem in LIST_COMPANIES.CheckedItems) _companyList.Remove(checkedItem);
            SetCompanies();
            _companies.Save(_companyList);
        }

        private void LoadCompanies()
        {
            _companies.Load(out var companies);
            _companyList = companies;
            SetCompanies();
        }

        private void LoadEmployees()
        {
            new ConnectingToDeviceProcessForm(() =>
            {
                _employees.LoadDeviceEmployees(out var messages);
                _messages = messages;
            }, Resources.LABEL_FETCHING_EMPLOYEES_FROM_DEVICE).ShowDialog(this);
            _messages.ForEach(message =>
            {
                Settings.Default._consoleLogs.Add(message);
                LIST_DEVICE_HARDWARE.Items.Add(message);
            });
        }

        private void GetEmployees(int companyId)
        {
            StartFetchingEmployees();
            Task.Factory.StartNew(() =>
                {
                    _employees.LoadEmployees(out var employees, companyId);
                    _employeeList = employees;
                })
                .ContinueWith(t => { DoneFetchingEmployees(); },
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void StartFetchingEmployees()
        {
            PROGRESS_EMPLOYEE.Visible = true;
            TIME_EMPLOYEE.Start();
            VALUE_SEARCH_EMPLOYEE.Enabled = false;
            SELECT_COMPANIES.Enabled = false;
            BUTTON_SELECT_ALL.Enabled = false;
            BUTTON_DESELECT_ALL.Enabled = false;
            BUTTON_SEARCH_EMPLOYEE.Enabled = false;
        }

        private void DoneFetchingEmployees()
        {
            SetEmployeeList();
            VALUE_SEARCH_EMPLOYEE.Enabled = true;
            SELECT_COMPANIES.Enabled = true;
            PROGRESS_EMPLOYEE.Visible = false;
            BUTTON_SELECT_ALL.Enabled = true;
            BUTTON_DESELECT_ALL.Enabled = true;
            BUTTON_SEARCH_EMPLOYEE.Enabled = true;
            TIME_EMPLOYEE.Stop();
        }

        private void SELECT_COMPANIES_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companyBox = (ComboBox) sender;
            if (companyBox.SelectedItem != null)
            {
                var company = (Companies.Company) companyBox.SelectedItem;
                GetEmployees(company.Id);
            }
        }

        private void SetEmployeeList()
        {
            LIST_EMPLOYEES.DataSource = _employeeList;
            LIST_EMPLOYEES.DisplayMember = "FullName";
            LIST_EMPLOYEES.ValueMember = "Id";
            for (var i = 0; i < _employeeList.Count; i++)
            {
                var emp = _employeeList[i];
                LIST_EMPLOYEES.SetItemChecked(i, emp.IsChecked);
            }
        }

        private void TIME_EMPLOYEE_Tick(object sender, EventArgs e)
        {
            if (PROGRESS_EMPLOYEE.Value == 100) PROGRESS_EMPLOYEE.Value = 0;
            PROGRESS_EMPLOYEE.Increment(5);
        }

        private void VALUE_SEARCH_EMPLOYEE_TextChanged(object sender, EventArgs e)
        {
            var text = ((TextBox) sender).Text;
            _employees.SetSearch(text);
            BUTTON_SEARCH_EMPLOYEE.Text =
                string.IsNullOrWhiteSpace(text) ? Resources.LABEL_REFRESH : Resources.LABEL_SEARCH;
        }

        private void VALUE_SEARCH_EMPLOYEE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchEmployee();
        }

        private void SearchEmployee()
        {
            if (SELECT_COMPANIES.SelectedItem != null)
            {
                var selectCompany = (Companies.Company) SELECT_COMPANIES.SelectedItem;
                StartFetchingEmployees();
                Task.Factory.StartNew(() =>
                    {
                        _employees.SearchEmployees(out var employees, selectCompany.Id);
                        _employeeList = employees;
                    })
                    .ContinueWith(t => { DoneFetchingEmployees(); },
                        TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void BUTTON_SEARCH_EMPLOYEE_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void LIST_EMPLOYEES_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var employees = (CheckedListBox) sender;
            var employeesItem = (Employees.Employee) employees.Items[e.Index];

            if (e.CurrentValue == CheckState.Checked && e.NewValue == CheckState.Unchecked)
                employeesItem.ToDelete = true;

            if (e.CurrentValue == CheckState.Unchecked && e.NewValue == CheckState.Checked) employeesItem.ToSave = true;
            _employees.ToggleEmployee(employeesItem);
        }

        private void BUTTON_SELECT_ALL_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < LIST_EMPLOYEES.Items.Count; i++) LIST_EMPLOYEES.SetItemChecked(i, true);
        }

        private void BUTTON_DESELECT_ALL_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < LIST_EMPLOYEES.Items.Count; i++) LIST_EMPLOYEES.SetItemChecked(i, false);
        }

        private void BUTTON_SAVE_EMPLOYEES_Click(object sender, EventArgs e)
        {
            new ConnectingToDeviceProcessForm(() =>
                {
                    _employees.SaveEmployees(out var messages);
                    _messages = messages;
                },
                "Sending employee updates to device...").ShowDialog(this);
            foreach (var message in _messages)
            {
                Settings.Default._consoleLogs.Add(message);
                LIST_DEVICE_HARDWARE.Items.Add(message);
            }
        }

        private void RefreshTabEmployee()
        {
            if (_companyList.Count > 0)
            {
                if (!TAB_FORM_TRAY.Controls.Contains(TAB_EMPLOYEE)) TAB_FORM_TRAY.Controls.Add(TAB_EMPLOYEE);
            }
            else
            {
                TAB_FORM_TRAY.Controls.Remove(TAB_EMPLOYEE);
            }
        }
    }
}