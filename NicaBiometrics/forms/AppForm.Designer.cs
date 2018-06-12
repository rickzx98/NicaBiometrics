using NicaBiometrics.Properties;

namespace NicaBiometrics.forms
{
    partial class TRAY_FORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip APP_CONTEXT_MENU;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRAY_FORM));
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TAB_FORM_TRAY = new System.Windows.Forms.TabControl();
            this.TAB_DEVICE_SETTING = new System.Windows.Forms.TabPage();
            this.PANEL_DEVICE_NET_SETTING = new System.Windows.Forms.Panel();
            this.BUTTON_CLEAR_LOGS = new System.Windows.Forms.Button();
            this.VALUE_DEVICE_ID = new System.Windows.Forms.TextBox();
            this.LABEL_DEVICE_ID = new System.Windows.Forms.Label();
            this.LABEL_COMM_KEY = new System.Windows.Forms.Label();
            this.VALUE_COMM_KEY = new System.Windows.Forms.TextBox();
            this.LIST_DEVICE_HARDWARE = new System.Windows.Forms.ListBox();
            this.BUTTON_REFRESH_USB_LIST = new System.Windows.Forms.Button();
            this.CHECK_VIA_USB = new System.Windows.Forms.CheckBox();
            this.CHECK_VIA_NET = new System.Windows.Forms.CheckBox();
            this.BUTTON_CONNECT = new System.Windows.Forms.Button();
            this.BUTTON_DEVICE_REFRESH = new System.Windows.Forms.Button();
            this.LABEL_DEVICE_PORT = new System.Windows.Forms.Label();
            this.LABEL_DEVICE_ADDRESS = new System.Windows.Forms.Label();
            this.VALUE_DEVICE_PORT = new System.Windows.Forms.TextBox();
            this.VALUE_DEVICE_ADDRESS = new System.Windows.Forms.TextBox();
            this.TAB_SERVER_SETTING = new System.Windows.Forms.TabPage();
            this.PANEL_SERVER_SETTING = new System.Windows.Forms.Panel();
            this.LABEL_COMPANY_URL = new System.Windows.Forms.Label();
            this.VALUE_COMPANY_URL = new System.Windows.Forms.TextBox();
            this.LIST_SERVER_LOGS = new System.Windows.Forms.ListBox();
            this.BUTTON_CLEAR_SERVER_LOGS = new System.Windows.Forms.Button();
            this.VALUE_EMPLOYEE_URL = new System.Windows.Forms.TextBox();
            this.LABEL_EMPLOYEE_URL = new System.Windows.Forms.Label();
            this.VALUE_TIMEOUT_URL = new System.Windows.Forms.TextBox();
            this.VALUE_TIMEIN_URL = new System.Windows.Forms.TextBox();
            this.LABEL_TIMEOUT_URL = new System.Windows.Forms.Label();
            this.LABEL_TIMEIN_URL = new System.Windows.Forms.Label();
            this.VALUE_SERVER_ADDRESS = new System.Windows.Forms.TextBox();
            this.BUTTON_REFRESH_SERVER = new System.Windows.Forms.Button();
            this.BUTTON_CONNECT_SERVER = new System.Windows.Forms.Button();
            this.LABEL_SERVER_IPADDRESS = new System.Windows.Forms.Label();
            this.TAB_REMOTE_CONTROL = new System.Windows.Forms.TabPage();
            this.VALUE_BIOTMETRIC_TYPE = new System.Windows.Forms.TextBox();
            this.LABEL_BIOMETRIC_TYPE = new System.Windows.Forms.Label();
            this.VALUE_MAC_ADD = new System.Windows.Forms.TextBox();
            this.LABEL_MAC_ADDRESS = new System.Windows.Forms.Label();
            this.BUTTON_RESTART = new System.Windows.Forms.Button();
            this.VALUE_SERIAL = new System.Windows.Forms.TextBox();
            this.LABEL_SERIAL = new System.Windows.Forms.Label();
            this.VALUE_DEVICE_NAME = new System.Windows.Forms.TextBox();
            this.LABEL_DEVICE_NAME = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TAB_COMPANY = new System.Windows.Forms.TabPage();
            this.BUTTON_REMOVE_COMPANY = new System.Windows.Forms.Button();
            this.BUTTON_ADD_COMPANY = new System.Windows.Forms.Button();
            this.LIST_COMPANIES = new System.Windows.Forms.CheckedListBox();
            this.TAB_EMPLOYEE = new System.Windows.Forms.TabPage();
            this.BUTTON_SAVE_EMPLOYEES = new System.Windows.Forms.Button();
            this.PROGRESS_EMPLOYEE = new System.Windows.Forms.ProgressBar();
            this.BUTTON_SEARCH_EMPLOYEE = new System.Windows.Forms.Button();
            this.BUTTON_DESELECT_ALL = new System.Windows.Forms.Button();
            this.BUTTON_SELECT_ALL = new System.Windows.Forms.Button();
            this.VALUE_SEARCH_EMPLOYEE = new System.Windows.Forms.TextBox();
            this.LIST_EMPLOYEES = new System.Windows.Forms.CheckedListBox();
            this.SELECT_COMPANIES = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TIME_LISTENER_LOG = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PANEL_GDS = new System.Windows.Forms.Panel();
            this.LABEL_NB = new System.Windows.Forms.LinkLabel();
            this.APP_TRAY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.TIME_EMPLOYEE = new System.Windows.Forms.Timer(this.components);
            APP_CONTEXT_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            APP_CONTEXT_MENU.SuspendLayout();
            this.TAB_FORM_TRAY.SuspendLayout();
            this.TAB_DEVICE_SETTING.SuspendLayout();
            this.PANEL_DEVICE_NET_SETTING.SuspendLayout();
            this.TAB_SERVER_SETTING.SuspendLayout();
            this.PANEL_SERVER_SETTING.SuspendLayout();
            this.TAB_REMOTE_CONTROL.SuspendLayout();
            this.TAB_COMPANY.SuspendLayout();
            this.TAB_EMPLOYEE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // APP_CONTEXT_MENU
            // 
            APP_CONTEXT_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            APP_CONTEXT_MENU.Name = "APPI_CONTEXT_MENU";
            APP_CONTEXT_MENU.Size = new System.Drawing.Size(104, 48);
            APP_CONTEXT_MENU.Click += new System.EventHandler(this.APP_CONTEXT_MENU_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 390);
            this.panel1.TabIndex = 2;
            // 
            // TAB_FORM_TRAY
            // 
            this.TAB_FORM_TRAY.Controls.Add(this.TAB_DEVICE_SETTING);
            this.TAB_FORM_TRAY.Controls.Add(this.TAB_SERVER_SETTING);
            this.TAB_FORM_TRAY.Controls.Add(this.TAB_REMOTE_CONTROL);
            this.TAB_FORM_TRAY.Controls.Add(this.TAB_COMPANY);
            this.TAB_FORM_TRAY.Controls.Add(this.TAB_EMPLOYEE);
            this.TAB_FORM_TRAY.Location = new System.Drawing.Point(113, -1);
            this.TAB_FORM_TRAY.Name = "TAB_FORM_TRAY";
            this.TAB_FORM_TRAY.SelectedIndex = 0;
            this.TAB_FORM_TRAY.Size = new System.Drawing.Size(382, 440);
            this.TAB_FORM_TRAY.TabIndex = 5;
            // 
            // TAB_DEVICE_SETTING
            // 
            this.TAB_DEVICE_SETTING.BackColor = System.Drawing.Color.OldLace;
            this.TAB_DEVICE_SETTING.Controls.Add(this.PANEL_DEVICE_NET_SETTING);
            this.TAB_DEVICE_SETTING.Location = new System.Drawing.Point(4, 22);
            this.TAB_DEVICE_SETTING.Name = "TAB_DEVICE_SETTING";
            this.TAB_DEVICE_SETTING.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_DEVICE_SETTING.Size = new System.Drawing.Size(374, 414);
            this.TAB_DEVICE_SETTING.TabIndex = 0;
            this.TAB_DEVICE_SETTING.Text = "Device";
            // 
            // PANEL_DEVICE_NET_SETTING
            // 
            this.PANEL_DEVICE_NET_SETTING.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_DEVICE_NET_SETTING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.BUTTON_CLEAR_LOGS);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.VALUE_DEVICE_ID);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.LABEL_DEVICE_ID);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.LABEL_COMM_KEY);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.VALUE_COMM_KEY);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.LIST_DEVICE_HARDWARE);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.BUTTON_REFRESH_USB_LIST);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.CHECK_VIA_USB);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.CHECK_VIA_NET);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.BUTTON_CONNECT);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.BUTTON_DEVICE_REFRESH);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.LABEL_DEVICE_PORT);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.LABEL_DEVICE_ADDRESS);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.VALUE_DEVICE_PORT);
            this.PANEL_DEVICE_NET_SETTING.Controls.Add(this.VALUE_DEVICE_ADDRESS);
            this.PANEL_DEVICE_NET_SETTING.Location = new System.Drawing.Point(0, 0);
            this.PANEL_DEVICE_NET_SETTING.Name = "PANEL_DEVICE_NET_SETTING";
            this.PANEL_DEVICE_NET_SETTING.Size = new System.Drawing.Size(378, 414);
            this.PANEL_DEVICE_NET_SETTING.TabIndex = 7;
            this.PANEL_DEVICE_NET_SETTING.Tag = "PANEL_DEVICE_NET_SETTING";
            // 
            // BUTTON_CLEAR_LOGS
            // 
            this.BUTTON_CLEAR_LOGS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CLEAR_LOGS.Location = new System.Drawing.Point(52, 230);
            this.BUTTON_CLEAR_LOGS.Name = "BUTTON_CLEAR_LOGS";
            this.BUTTON_CLEAR_LOGS.Size = new System.Drawing.Size(68, 30);
            this.BUTTON_CLEAR_LOGS.TabIndex = 16;
            this.BUTTON_CLEAR_LOGS.Tag = "BUTTON_CLEAR_LOGS";
            this.BUTTON_CLEAR_LOGS.Text = global::NicaBiometrics.Properties.Resources.LABEL_CLEAR_LOGS;
            this.BUTTON_CLEAR_LOGS.UseVisualStyleBackColor = true;
            this.BUTTON_CLEAR_LOGS.Click += new System.EventHandler(this.BUTTON_CLEAR_LOGS_Click);
            // 
            // VALUE_DEVICE_ID
            // 
            this.VALUE_DEVICE_ID.Location = new System.Drawing.Point(111, 173);
            this.VALUE_DEVICE_ID.Name = "VALUE_DEVICE_ID";
            this.VALUE_DEVICE_ID.Size = new System.Drawing.Size(106, 20);
            this.VALUE_DEVICE_ID.TabIndex = 15;
            this.VALUE_DEVICE_ID.Tag = "VALUE_DEVICE_ID";
            this.VALUE_DEVICE_ID.TextChanged += new System.EventHandler(this.VALUE_DEVICE_ID_TextChanged);
            // 
            // LABEL_DEVICE_ID
            // 
            this.LABEL_DEVICE_ID.AutoSize = true;
            this.LABEL_DEVICE_ID.Location = new System.Drawing.Point(49, 176);
            this.LABEL_DEVICE_ID.Name = "LABEL_DEVICE_ID";
            this.LABEL_DEVICE_ID.Size = new System.Drawing.Size(52, 13);
            this.LABEL_DEVICE_ID.TabIndex = 14;
            this.LABEL_DEVICE_ID.Tag = "LABEL_DEVICE_ID";
            this.LABEL_DEVICE_ID.Text = "Device id";
            // 
            // LABEL_COMM_KEY
            // 
            this.LABEL_COMM_KEY.AutoSize = true;
            this.LABEL_COMM_KEY.Location = new System.Drawing.Point(49, 202);
            this.LABEL_COMM_KEY.Name = "LABEL_COMM_KEY";
            this.LABEL_COMM_KEY.Size = new System.Drawing.Size(56, 13);
            this.LABEL_COMM_KEY.TabIndex = 13;
            this.LABEL_COMM_KEY.Tag = "LABEL_COMM_KEY";
            this.LABEL_COMM_KEY.Text = "Comm key";
            // 
            // VALUE_COMM_KEY
            // 
            this.VALUE_COMM_KEY.Location = new System.Drawing.Point(111, 199);
            this.VALUE_COMM_KEY.Name = "VALUE_COMM_KEY";
            this.VALUE_COMM_KEY.Size = new System.Drawing.Size(106, 20);
            this.VALUE_COMM_KEY.TabIndex = 12;
            this.VALUE_COMM_KEY.Tag = "VALUE_COMM_KEY";
            this.VALUE_COMM_KEY.TextChanged += new System.EventHandler(this.VALUE_COMM_KEY_TextChanged);
            // 
            // LIST_DEVICE_HARDWARE
            // 
            this.LIST_DEVICE_HARDWARE.BackColor = System.Drawing.SystemColors.WindowText;
            this.LIST_DEVICE_HARDWARE.ForeColor = System.Drawing.SystemColors.Window;
            this.LIST_DEVICE_HARDWARE.FormattingEnabled = true;
            this.LIST_DEVICE_HARDWARE.HorizontalScrollbar = true;
            this.LIST_DEVICE_HARDWARE.Location = new System.Drawing.Point(52, 266);
            this.LIST_DEVICE_HARDWARE.Name = "LIST_DEVICE_HARDWARE";
            this.LIST_DEVICE_HARDWARE.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LIST_DEVICE_HARDWARE.Size = new System.Drawing.Size(286, 134);
            this.LIST_DEVICE_HARDWARE.TabIndex = 11;
            this.LIST_DEVICE_HARDWARE.Tag = "LIST_DEVICE_HARDWARE";
            // 
            // BUTTON_REFRESH_USB_LIST
            // 
            this.BUTTON_REFRESH_USB_LIST.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_REFRESH_USB_LIST.Location = new System.Drawing.Point(263, 189);
            this.BUTTON_REFRESH_USB_LIST.Name = "BUTTON_REFRESH_USB_LIST";
            this.BUTTON_REFRESH_USB_LIST.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_REFRESH_USB_LIST.TabIndex = 10;
            this.BUTTON_REFRESH_USB_LIST.TabStop = false;
            this.BUTTON_REFRESH_USB_LIST.Text = "Refresh";
            this.BUTTON_REFRESH_USB_LIST.UseVisualStyleBackColor = true;
            this.BUTTON_REFRESH_USB_LIST.Click += new System.EventHandler(this.BUTTON_REFRESH_USB_LIST_Click);
            // 
            // CHECK_VIA_USB
            // 
            this.CHECK_VIA_USB.AutoSize = true;
            this.CHECK_VIA_USB.Location = new System.Drawing.Point(111, 150);
            this.CHECK_VIA_USB.Name = "CHECK_VIA_USB";
            this.CHECK_VIA_USB.Size = new System.Drawing.Size(108, 17);
            this.CHECK_VIA_USB.TabIndex = 8;
            this.CHECK_VIA_USB.Text = "Connect via USB";
            this.CHECK_VIA_USB.UseVisualStyleBackColor = true;
            this.CHECK_VIA_USB.CheckedChanged += new System.EventHandler(this.CHECK_VIA_USB_CheckedChanged);
            // 
            // CHECK_VIA_NET
            // 
            this.CHECK_VIA_NET.AutoSize = true;
            this.CHECK_VIA_NET.Location = new System.Drawing.Point(111, 26);
            this.CHECK_VIA_NET.Name = "CHECK_VIA_NET";
            this.CHECK_VIA_NET.Size = new System.Drawing.Size(124, 17);
            this.CHECK_VIA_NET.TabIndex = 7;
            this.CHECK_VIA_NET.Tag = "CHECK_VIA_NET";
            this.CHECK_VIA_NET.Text = "Connect via network";
            this.CHECK_VIA_NET.UseVisualStyleBackColor = true;
            this.CHECK_VIA_NET.CheckedChanged += new System.EventHandler(this.CHECK_VIA_NET_CheckedChanged);
            // 
            // BUTTON_CONNECT
            // 
            this.BUTTON_CONNECT.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BUTTON_CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CONNECT.Location = new System.Drawing.Point(182, 101);
            this.BUTTON_CONNECT.Name = "BUTTON_CONNECT";
            this.BUTTON_CONNECT.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_CONNECT.TabIndex = 6;
            this.BUTTON_CONNECT.Text = "Connect";
            this.BUTTON_CONNECT.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT.UseWaitCursor = true;
            this.BUTTON_CONNECT.Click += new System.EventHandler(this.BUTTON_CONNECT_Click);
            // 
            // BUTTON_DEVICE_REFRESH
            // 
            this.BUTTON_DEVICE_REFRESH.BackColor = System.Drawing.Color.White;
            this.BUTTON_DEVICE_REFRESH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_DEVICE_REFRESH.Location = new System.Drawing.Point(263, 101);
            this.BUTTON_DEVICE_REFRESH.Name = "BUTTON_DEVICE_REFRESH";
            this.BUTTON_DEVICE_REFRESH.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_DEVICE_REFRESH.TabIndex = 3;
            this.BUTTON_DEVICE_REFRESH.Text = "Refresh";
            this.BUTTON_DEVICE_REFRESH.UseVisualStyleBackColor = false;
            this.BUTTON_DEVICE_REFRESH.Click += new System.EventHandler(this.BUTTON_REFRESH_Click);
            // 
            // LABEL_DEVICE_PORT
            // 
            this.LABEL_DEVICE_PORT.AutoSize = true;
            this.LABEL_DEVICE_PORT.BackColor = System.Drawing.Color.OldLace;
            this.LABEL_DEVICE_PORT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LABEL_DEVICE_PORT.Location = new System.Drawing.Point(80, 78);
            this.LABEL_DEVICE_PORT.Name = "LABEL_DEVICE_PORT";
            this.LABEL_DEVICE_PORT.Size = new System.Drawing.Size(26, 13);
            this.LABEL_DEVICE_PORT.TabIndex = 4;
            this.LABEL_DEVICE_PORT.Text = "Port";
            // 
            // LABEL_DEVICE_ADDRESS
            // 
            this.LABEL_DEVICE_ADDRESS.AutoSize = true;
            this.LABEL_DEVICE_ADDRESS.BackColor = System.Drawing.Color.OldLace;
            this.LABEL_DEVICE_ADDRESS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LABEL_DEVICE_ADDRESS.Location = new System.Drawing.Point(10, 52);
            this.LABEL_DEVICE_ADDRESS.Name = "LABEL_DEVICE_ADDRESS";
            this.LABEL_DEVICE_ADDRESS.Size = new System.Drawing.Size(95, 13);
            this.LABEL_DEVICE_ADDRESS.TabIndex = 0;
            this.LABEL_DEVICE_ADDRESS.Tag = "LABEL_DEVICE_ADDRESS";
            this.LABEL_DEVICE_ADDRESS.Text = "Device IP Address";
            // 
            // VALUE_DEVICE_PORT
            // 
            this.VALUE_DEVICE_PORT.Location = new System.Drawing.Point(111, 75);
            this.VALUE_DEVICE_PORT.Name = "VALUE_DEVICE_PORT";
            this.VALUE_DEVICE_PORT.Size = new System.Drawing.Size(106, 20);
            this.VALUE_DEVICE_PORT.TabIndex = 5;
            this.VALUE_DEVICE_PORT.Tag = "VALUE_DEVICE_PORT";
            this.VALUE_DEVICE_PORT.TextChanged += new System.EventHandler(this.VALUE_DEVICE_PORT_TextChanged);
            // 
            // VALUE_DEVICE_ADDRESS
            // 
            this.VALUE_DEVICE_ADDRESS.Location = new System.Drawing.Point(111, 49);
            this.VALUE_DEVICE_ADDRESS.Name = "VALUE_DEVICE_ADDRESS";
            this.VALUE_DEVICE_ADDRESS.Size = new System.Drawing.Size(190, 20);
            this.VALUE_DEVICE_ADDRESS.TabIndex = 1;
            this.VALUE_DEVICE_ADDRESS.Tag = "VALUE_DEVICE_ADDRESS";
            this.VALUE_DEVICE_ADDRESS.TextChanged += new System.EventHandler(this.VALUE_DEVICE_ADDRESS_TextChanged);
            // 
            // TAB_SERVER_SETTING
            // 
            this.TAB_SERVER_SETTING.BackColor = System.Drawing.Color.OldLace;
            this.TAB_SERVER_SETTING.Controls.Add(this.PANEL_SERVER_SETTING);
            this.TAB_SERVER_SETTING.Location = new System.Drawing.Point(4, 22);
            this.TAB_SERVER_SETTING.Name = "TAB_SERVER_SETTING";
            this.TAB_SERVER_SETTING.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_SERVER_SETTING.Size = new System.Drawing.Size(374, 414);
            this.TAB_SERVER_SETTING.TabIndex = 1;
            this.TAB_SERVER_SETTING.Text = "Server";
            // 
            // PANEL_SERVER_SETTING
            // 
            this.PANEL_SERVER_SETTING.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_SERVER_SETTING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_COMPANY_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_COMPANY_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LIST_SERVER_LOGS);
            this.PANEL_SERVER_SETTING.Controls.Add(this.BUTTON_CLEAR_SERVER_LOGS);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_EMPLOYEE_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_EMPLOYEE_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_TIMEOUT_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_TIMEIN_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_TIMEOUT_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_TIMEIN_URL);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_SERVER_ADDRESS);
            this.PANEL_SERVER_SETTING.Controls.Add(this.BUTTON_REFRESH_SERVER);
            this.PANEL_SERVER_SETTING.Controls.Add(this.BUTTON_CONNECT_SERVER);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_SERVER_IPADDRESS);
            this.PANEL_SERVER_SETTING.Location = new System.Drawing.Point(0, 0);
            this.PANEL_SERVER_SETTING.Name = "PANEL_SERVER_SETTING";
            this.PANEL_SERVER_SETTING.Size = new System.Drawing.Size(374, 414);
            this.PANEL_SERVER_SETTING.TabIndex = 9;
            // 
            // LABEL_COMPANY_URL
            // 
            this.LABEL_COMPANY_URL.AutoSize = true;
            this.LABEL_COMPANY_URL.Location = new System.Drawing.Point(29, 94);
            this.LABEL_COMPANY_URL.Name = "LABEL_COMPANY_URL";
            this.LABEL_COMPANY_URL.Size = new System.Drawing.Size(76, 13);
            this.LABEL_COMPANY_URL.TabIndex = 23;
            this.LABEL_COMPANY_URL.Tag = "LABEL_COMPANY_URL";
            this.LABEL_COMPANY_URL.Text = "Company URL";
            // 
            // VALUE_COMPANY_URL
            // 
            this.VALUE_COMPANY_URL.Location = new System.Drawing.Point(111, 91);
            this.VALUE_COMPANY_URL.Name = "VALUE_COMPANY_URL";
            this.VALUE_COMPANY_URL.Size = new System.Drawing.Size(190, 20);
            this.VALUE_COMPANY_URL.TabIndex = 22;
            this.VALUE_COMPANY_URL.Tag = "VALUE_COMPANY_URL";
            // 
            // LIST_SERVER_LOGS
            // 
            this.LIST_SERVER_LOGS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LIST_SERVER_LOGS.ForeColor = System.Drawing.SystemColors.Window;
            this.LIST_SERVER_LOGS.FormattingEnabled = true;
            this.LIST_SERVER_LOGS.HorizontalScrollbar = true;
            this.LIST_SERVER_LOGS.Location = new System.Drawing.Point(52, 266);
            this.LIST_SERVER_LOGS.Name = "LIST_SERVER_LOGS";
            this.LIST_SERVER_LOGS.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LIST_SERVER_LOGS.Size = new System.Drawing.Size(286, 134);
            this.LIST_SERVER_LOGS.TabIndex = 21;
            this.LIST_SERVER_LOGS.Tag = "LIST_SERVER_LOGS";
            // 
            // BUTTON_CLEAR_SERVER_LOGS
            // 
            this.BUTTON_CLEAR_SERVER_LOGS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CLEAR_SERVER_LOGS.Location = new System.Drawing.Point(52, 230);
            this.BUTTON_CLEAR_SERVER_LOGS.Name = "BUTTON_CLEAR_SERVER_LOGS";
            this.BUTTON_CLEAR_SERVER_LOGS.Size = new System.Drawing.Size(68, 30);
            this.BUTTON_CLEAR_SERVER_LOGS.TabIndex = 20;
            this.BUTTON_CLEAR_SERVER_LOGS.Tag = "BUTTON_CLEAR_SERVER_LOGS";
            this.BUTTON_CLEAR_SERVER_LOGS.Text = global::NicaBiometrics.Properties.Resources.LABEL_CLEAR_LOGS;
            this.BUTTON_CLEAR_SERVER_LOGS.UseVisualStyleBackColor = true;
            this.BUTTON_CLEAR_SERVER_LOGS.Click += new System.EventHandler(this.BUTTON_CLEAR_SERVER_LOGS_Click);
            // 
            // VALUE_EMPLOYEE_URL
            // 
            this.VALUE_EMPLOYEE_URL.Location = new System.Drawing.Point(111, 194);
            this.VALUE_EMPLOYEE_URL.Name = "VALUE_EMPLOYEE_URL";
            this.VALUE_EMPLOYEE_URL.Size = new System.Drawing.Size(190, 20);
            this.VALUE_EMPLOYEE_URL.TabIndex = 19;
            this.VALUE_EMPLOYEE_URL.Tag = "VALUE_EMPLOYEE_URL";
            this.VALUE_EMPLOYEE_URL.TextChanged += new System.EventHandler(this.VALUE_EMPLOYEE_URL_TextChanged);
            // 
            // LABEL_EMPLOYEE_URL
            // 
            this.LABEL_EMPLOYEE_URL.AutoSize = true;
            this.LABEL_EMPLOYEE_URL.Location = new System.Drawing.Point(27, 197);
            this.LABEL_EMPLOYEE_URL.Name = "LABEL_EMPLOYEE_URL";
            this.LABEL_EMPLOYEE_URL.Size = new System.Drawing.Size(78, 13);
            this.LABEL_EMPLOYEE_URL.TabIndex = 18;
            this.LABEL_EMPLOYEE_URL.Tag = "LABEL_EMPLOYEE_URL";
            this.LABEL_EMPLOYEE_URL.Text = "Employee URL";
            // 
            // VALUE_TIMEOUT_URL
            // 
            this.VALUE_TIMEOUT_URL.Location = new System.Drawing.Point(111, 160);
            this.VALUE_TIMEOUT_URL.Name = "VALUE_TIMEOUT_URL";
            this.VALUE_TIMEOUT_URL.Size = new System.Drawing.Size(190, 20);
            this.VALUE_TIMEOUT_URL.TabIndex = 17;
            this.VALUE_TIMEOUT_URL.Tag = "VALUE_TIMEOUT_URL";
            this.VALUE_TIMEOUT_URL.TextChanged += new System.EventHandler(this.VALUE_TIMEOUT_URL_TextChanged);
            // 
            // VALUE_TIMEIN_URL
            // 
            this.VALUE_TIMEIN_URL.Location = new System.Drawing.Point(111, 125);
            this.VALUE_TIMEIN_URL.Name = "VALUE_TIMEIN_URL";
            this.VALUE_TIMEIN_URL.Size = new System.Drawing.Size(190, 20);
            this.VALUE_TIMEIN_URL.TabIndex = 16;
            this.VALUE_TIMEIN_URL.Tag = "VALUE_TIMEIN_URL";
            this.VALUE_TIMEIN_URL.TextChanged += new System.EventHandler(this.VALUE_TIMEIN_URL_TextChanged);
            // 
            // LABEL_TIMEOUT_URL
            // 
            this.LABEL_TIMEOUT_URL.AutoSize = true;
            this.LABEL_TIMEOUT_URL.Location = new System.Drawing.Point(32, 164);
            this.LABEL_TIMEOUT_URL.Name = "LABEL_TIMEOUT_URL";
            this.LABEL_TIMEOUT_URL.Size = new System.Drawing.Size(73, 13);
            this.LABEL_TIMEOUT_URL.TabIndex = 15;
            this.LABEL_TIMEOUT_URL.Tag = "LABEL_TIMEOUT_URL";
            this.LABEL_TIMEOUT_URL.Text = "Time out URL";
            // 
            // LABEL_TIMEIN_URL
            // 
            this.LABEL_TIMEIN_URL.AutoSize = true;
            this.LABEL_TIMEIN_URL.Location = new System.Drawing.Point(39, 129);
            this.LABEL_TIMEIN_URL.Name = "LABEL_TIMEIN_URL";
            this.LABEL_TIMEIN_URL.Size = new System.Drawing.Size(66, 13);
            this.LABEL_TIMEIN_URL.TabIndex = 14;
            this.LABEL_TIMEIN_URL.Tag = "LABEL_TIMEIN_URL";
            this.LABEL_TIMEIN_URL.Text = "Time in URL";
            // 
            // VALUE_SERVER_ADDRESS
            // 
            this.VALUE_SERVER_ADDRESS.Location = new System.Drawing.Point(111, 14);
            this.VALUE_SERVER_ADDRESS.Name = "VALUE_SERVER_ADDRESS";
            this.VALUE_SERVER_ADDRESS.Size = new System.Drawing.Size(190, 20);
            this.VALUE_SERVER_ADDRESS.TabIndex = 13;
            this.VALUE_SERVER_ADDRESS.Tag = "VALUE_SERVER_ADDRESS";
            this.VALUE_SERVER_ADDRESS.TextChanged += new System.EventHandler(this.VALUE_SERVER_ADDRESS_TextChanged);
            // 
            // BUTTON_REFRESH_SERVER
            // 
            this.BUTTON_REFRESH_SERVER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUTTON_REFRESH_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_REFRESH_SERVER.Location = new System.Drawing.Point(268, 40);
            this.BUTTON_REFRESH_SERVER.Name = "BUTTON_REFRESH_SERVER";
            this.BUTTON_REFRESH_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_REFRESH_SERVER.TabIndex = 12;
            this.BUTTON_REFRESH_SERVER.Text = "Refresh";
            this.BUTTON_REFRESH_SERVER.UseVisualStyleBackColor = false;
            this.BUTTON_REFRESH_SERVER.Click += new System.EventHandler(this.BUTTON_REFRESH_SERVER_Click);
            // 
            // BUTTON_CONNECT_SERVER
            // 
            this.BUTTON_CONNECT_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CONNECT_SERVER.Location = new System.Drawing.Point(187, 40);
            this.BUTTON_CONNECT_SERVER.Name = "BUTTON_CONNECT_SERVER";
            this.BUTTON_CONNECT_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_CONNECT_SERVER.TabIndex = 11;
            this.BUTTON_CONNECT_SERVER.Text = "Connect";
            this.BUTTON_CONNECT_SERVER.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT_SERVER.Click += new System.EventHandler(this.BUTTON_CONNECT_SERVER_Click);
            // 
            // LABEL_SERVER_IPADDRESS
            // 
            this.LABEL_SERVER_IPADDRESS.AutoSize = true;
            this.LABEL_SERVER_IPADDRESS.Location = new System.Drawing.Point(27, 17);
            this.LABEL_SERVER_IPADDRESS.Name = "LABEL_SERVER_IPADDRESS";
            this.LABEL_SERVER_IPADDRESS.Size = new System.Drawing.Size(78, 13);
            this.LABEL_SERVER_IPADDRESS.TabIndex = 2;
            this.LABEL_SERVER_IPADDRESS.Text = "Server  domain";
            // 
            // TAB_REMOTE_CONTROL
            // 
            this.TAB_REMOTE_CONTROL.BackColor = System.Drawing.Color.OldLace;
            this.TAB_REMOTE_CONTROL.Controls.Add(this.VALUE_BIOTMETRIC_TYPE);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.LABEL_BIOMETRIC_TYPE);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.VALUE_MAC_ADD);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.LABEL_MAC_ADDRESS);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.BUTTON_RESTART);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.VALUE_SERIAL);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.LABEL_SERIAL);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.VALUE_DEVICE_NAME);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.LABEL_DEVICE_NAME);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.panel2);
            this.TAB_REMOTE_CONTROL.Location = new System.Drawing.Point(4, 22);
            this.TAB_REMOTE_CONTROL.Name = "TAB_REMOTE_CONTROL";
            this.TAB_REMOTE_CONTROL.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_REMOTE_CONTROL.Size = new System.Drawing.Size(374, 414);
            this.TAB_REMOTE_CONTROL.TabIndex = 2;
            this.TAB_REMOTE_CONTROL.Tag = "TAB_REMOTE_CONTROL";
            this.TAB_REMOTE_CONTROL.Text = global::NicaBiometrics.Properties.Resources.LABEL_REMOTE;
            // 
            // VALUE_BIOTMETRIC_TYPE
            // 
            this.VALUE_BIOTMETRIC_TYPE.Location = new System.Drawing.Point(232, 103);
            this.VALUE_BIOTMETRIC_TYPE.Name = "VALUE_BIOTMETRIC_TYPE";
            this.VALUE_BIOTMETRIC_TYPE.ReadOnly = true;
            this.VALUE_BIOTMETRIC_TYPE.Size = new System.Drawing.Size(127, 20);
            this.VALUE_BIOTMETRIC_TYPE.TabIndex = 10;
            this.VALUE_BIOTMETRIC_TYPE.Tag = "VALUE_BIOTMETRIC_TYPE";
            // 
            // LABEL_BIOMETRIC_TYPE
            // 
            this.LABEL_BIOMETRIC_TYPE.AutoSize = true;
            this.LABEL_BIOMETRIC_TYPE.Location = new System.Drawing.Point(170, 106);
            this.LABEL_BIOMETRIC_TYPE.Name = "LABEL_BIOMETRIC_TYPE";
            this.LABEL_BIOMETRIC_TYPE.Size = new System.Drawing.Size(55, 13);
            this.LABEL_BIOMETRIC_TYPE.TabIndex = 9;
            this.LABEL_BIOMETRIC_TYPE.Tag = "LABEL_BIOMETRIC_TYPE";
            this.LABEL_BIOMETRIC_TYPE.Text = "Biometrics";
            // 
            // VALUE_MAC_ADD
            // 
            this.VALUE_MAC_ADD.Location = new System.Drawing.Point(232, 72);
            this.VALUE_MAC_ADD.Name = "VALUE_MAC_ADD";
            this.VALUE_MAC_ADD.ReadOnly = true;
            this.VALUE_MAC_ADD.Size = new System.Drawing.Size(127, 20);
            this.VALUE_MAC_ADD.TabIndex = 8;
            this.VALUE_MAC_ADD.Tag = "VALUE_MAC_ADD";
            // 
            // LABEL_MAC_ADDRESS
            // 
            this.LABEL_MAC_ADDRESS.AutoSize = true;
            this.LABEL_MAC_ADDRESS.Location = new System.Drawing.Point(154, 76);
            this.LABEL_MAC_ADDRESS.Name = "LABEL_MAC_ADDRESS";
            this.LABEL_MAC_ADDRESS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LABEL_MAC_ADDRESS.Size = new System.Drawing.Size(68, 13);
            this.LABEL_MAC_ADDRESS.TabIndex = 7;
            this.LABEL_MAC_ADDRESS.Tag = "LABEL_MAC_ADDRESS";
            this.LABEL_MAC_ADDRESS.Text = "Mac address";
            // 
            // BUTTON_RESTART
            // 
            this.BUTTON_RESTART.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_RESTART.Location = new System.Drawing.Point(152, 129);
            this.BUTTON_RESTART.Name = "BUTTON_RESTART";
            this.BUTTON_RESTART.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_RESTART.TabIndex = 6;
            this.BUTTON_RESTART.Tag = "BUTTON_RESTART";
            this.BUTTON_RESTART.Text = global::NicaBiometrics.Properties.Resources.LABEL_RESTART;
            this.BUTTON_RESTART.UseVisualStyleBackColor = true;
            this.BUTTON_RESTART.Click += new System.EventHandler(this.BUTTON_RESTART_Click);
            // 
            // VALUE_SERIAL
            // 
            this.VALUE_SERIAL.Location = new System.Drawing.Point(232, 45);
            this.VALUE_SERIAL.Name = "VALUE_SERIAL";
            this.VALUE_SERIAL.ReadOnly = true;
            this.VALUE_SERIAL.Size = new System.Drawing.Size(127, 20);
            this.VALUE_SERIAL.TabIndex = 4;
            this.VALUE_SERIAL.Tag = "VALUE_SERIAL";
            // 
            // LABEL_SERIAL
            // 
            this.LABEL_SERIAL.AutoSize = true;
            this.LABEL_SERIAL.Location = new System.Drawing.Point(189, 48);
            this.LABEL_SERIAL.Name = "LABEL_SERIAL";
            this.LABEL_SERIAL.Size = new System.Drawing.Size(33, 13);
            this.LABEL_SERIAL.TabIndex = 3;
            this.LABEL_SERIAL.Tag = "LABEL_SERIAL";
            this.LABEL_SERIAL.Text = "Serial";
            // 
            // VALUE_DEVICE_NAME
            // 
            this.VALUE_DEVICE_NAME.Location = new System.Drawing.Point(232, 19);
            this.VALUE_DEVICE_NAME.Name = "VALUE_DEVICE_NAME";
            this.VALUE_DEVICE_NAME.ReadOnly = true;
            this.VALUE_DEVICE_NAME.Size = new System.Drawing.Size(127, 20);
            this.VALUE_DEVICE_NAME.TabIndex = 2;
            this.VALUE_DEVICE_NAME.Tag = "VALUE_DEVICE_NAME";
            this.VALUE_DEVICE_NAME.Text = "ZKT 629";
            // 
            // LABEL_DEVICE_NAME
            // 
            this.LABEL_DEVICE_NAME.AutoSize = true;
            this.LABEL_DEVICE_NAME.Location = new System.Drawing.Point(155, 22);
            this.LABEL_DEVICE_NAME.Name = "LABEL_DEVICE_NAME";
            this.LABEL_DEVICE_NAME.Size = new System.Drawing.Size(70, 13);
            this.LABEL_DEVICE_NAME.TabIndex = 1;
            this.LABEL_DEVICE_NAME.Tag = "LABEL_DEVICE_NAME";
            this.LABEL_DEVICE_NAME.Text = "Device name";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 140);
            this.panel2.TabIndex = 0;
            this.panel2.Tag = "s";
            // 
            // TAB_COMPANY
            // 
            this.TAB_COMPANY.BackColor = System.Drawing.Color.OldLace;
            this.TAB_COMPANY.Controls.Add(this.BUTTON_REMOVE_COMPANY);
            this.TAB_COMPANY.Controls.Add(this.BUTTON_ADD_COMPANY);
            this.TAB_COMPANY.Controls.Add(this.LIST_COMPANIES);
            this.TAB_COMPANY.Location = new System.Drawing.Point(4, 22);
            this.TAB_COMPANY.Name = "TAB_COMPANY";
            this.TAB_COMPANY.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_COMPANY.Size = new System.Drawing.Size(374, 414);
            this.TAB_COMPANY.TabIndex = 3;
            this.TAB_COMPANY.Tag = "TAB_COMPANY";
            this.TAB_COMPANY.Text = global::NicaBiometrics.Properties.Resources.LABEL_COMPANY;
            // 
            // BUTTON_REMOVE_COMPANY
            // 
            this.BUTTON_REMOVE_COMPANY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_REMOVE_COMPANY.Location = new System.Drawing.Point(268, 15);
            this.BUTTON_REMOVE_COMPANY.Name = "BUTTON_REMOVE_COMPANY";
            this.BUTTON_REMOVE_COMPANY.Size = new System.Drawing.Size(70, 30);
            this.BUTTON_REMOVE_COMPANY.TabIndex = 2;
            this.BUTTON_REMOVE_COMPANY.Tag = "BUTTON_REMOVE_COMPANY";
            this.BUTTON_REMOVE_COMPANY.Text = global::NicaBiometrics.Properties.Resources.LABEL_REMOVE_COMPANY;
            this.BUTTON_REMOVE_COMPANY.UseVisualStyleBackColor = true;
            this.BUTTON_REMOVE_COMPANY.Click += new System.EventHandler(this.BUTTON_REMOVE_COMPANY_Click);
            // 
            // BUTTON_ADD_COMPANY
            // 
            this.BUTTON_ADD_COMPANY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_ADD_COMPANY.Location = new System.Drawing.Point(192, 15);
            this.BUTTON_ADD_COMPANY.Name = "BUTTON_ADD_COMPANY";
            this.BUTTON_ADD_COMPANY.Size = new System.Drawing.Size(70, 30);
            this.BUTTON_ADD_COMPANY.TabIndex = 1;
            this.BUTTON_ADD_COMPANY.Tag = "BUTTON_ADD_COMPANY";
            this.BUTTON_ADD_COMPANY.Text = "Add";
            this.BUTTON_ADD_COMPANY.UseVisualStyleBackColor = true;
            this.BUTTON_ADD_COMPANY.Click += new System.EventHandler(this.BUTTON_ADD_COMPANY_Click);
            // 
            // LIST_COMPANIES
            // 
            this.LIST_COMPANIES.CheckOnClick = true;
            this.LIST_COMPANIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_COMPANIES.FormattingEnabled = true;
            this.LIST_COMPANIES.Location = new System.Drawing.Point(52, 48);
            this.LIST_COMPANIES.Name = "LIST_COMPANIES";
            this.LIST_COMPANIES.Size = new System.Drawing.Size(286, 340);
            this.LIST_COMPANIES.TabIndex = 0;
            this.LIST_COMPANIES.Tag = "LIST_COMPANIES";
            // 
            // TAB_EMPLOYEE
            // 
            this.TAB_EMPLOYEE.BackColor = System.Drawing.Color.OldLace;
            this.TAB_EMPLOYEE.Controls.Add(this.BUTTON_SAVE_EMPLOYEES);
            this.TAB_EMPLOYEE.Controls.Add(this.PROGRESS_EMPLOYEE);
            this.TAB_EMPLOYEE.Controls.Add(this.BUTTON_SEARCH_EMPLOYEE);
            this.TAB_EMPLOYEE.Controls.Add(this.BUTTON_DESELECT_ALL);
            this.TAB_EMPLOYEE.Controls.Add(this.BUTTON_SELECT_ALL);
            this.TAB_EMPLOYEE.Controls.Add(this.VALUE_SEARCH_EMPLOYEE);
            this.TAB_EMPLOYEE.Controls.Add(this.LIST_EMPLOYEES);
            this.TAB_EMPLOYEE.Controls.Add(this.SELECT_COMPANIES);
            this.TAB_EMPLOYEE.Location = new System.Drawing.Point(4, 22);
            this.TAB_EMPLOYEE.Name = "TAB_EMPLOYEE";
            this.TAB_EMPLOYEE.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_EMPLOYEE.Size = new System.Drawing.Size(374, 414);
            this.TAB_EMPLOYEE.TabIndex = 4;
            this.TAB_EMPLOYEE.Tag = "TAB_EMPLOYEE";
            this.TAB_EMPLOYEE.Text = global::NicaBiometrics.Properties.Resources.LABEL_EMPLOYEE;
            // 
            // BUTTON_SAVE_EMPLOYEES
            // 
            this.BUTTON_SAVE_EMPLOYEES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SAVE_EMPLOYEES.Location = new System.Drawing.Point(216, 74);
            this.BUTTON_SAVE_EMPLOYEES.Name = "BUTTON_SAVE_EMPLOYEES";
            this.BUTTON_SAVE_EMPLOYEES.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_SAVE_EMPLOYEES.TabIndex = 7;
            this.BUTTON_SAVE_EMPLOYEES.Tag = "BUTTON_SAVE_EMPLOYEES";
            this.BUTTON_SAVE_EMPLOYEES.Text = global::NicaBiometrics.Properties.Resources.LABEL_SAVE;
            this.BUTTON_SAVE_EMPLOYEES.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE_EMPLOYEES.Click += new System.EventHandler(this.BUTTON_SAVE_EMPLOYEES_Click);
            // 
            // PROGRESS_EMPLOYEE
            // 
            this.PROGRESS_EMPLOYEE.Cursor = System.Windows.Forms.Cursors.Default;
            this.PROGRESS_EMPLOYEE.Location = new System.Drawing.Point(52, 391);
            this.PROGRESS_EMPLOYEE.Name = "PROGRESS_EMPLOYEE";
            this.PROGRESS_EMPLOYEE.Size = new System.Drawing.Size(286, 20);
            this.PROGRESS_EMPLOYEE.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PROGRESS_EMPLOYEE.TabIndex = 6;
            this.PROGRESS_EMPLOYEE.Tag = "PROGRESS_EMPLOYEE";
            // 
            // BUTTON_SEARCH_EMPLOYEE
            // 
            this.BUTTON_SEARCH_EMPLOYEE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SEARCH_EMPLOYEE.Location = new System.Drawing.Point(263, 42);
            this.BUTTON_SEARCH_EMPLOYEE.Name = "BUTTON_SEARCH_EMPLOYEE";
            this.BUTTON_SEARCH_EMPLOYEE.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_SEARCH_EMPLOYEE.TabIndex = 5;
            this.BUTTON_SEARCH_EMPLOYEE.Text = global::NicaBiometrics.Properties.Resources.LABEL_REFRESH;
            this.BUTTON_SEARCH_EMPLOYEE.UseVisualStyleBackColor = true;
            this.BUTTON_SEARCH_EMPLOYEE.Click += new System.EventHandler(this.BUTTON_SEARCH_EMPLOYEE_Click);
            // 
            // BUTTON_DESELECT_ALL
            // 
            this.BUTTON_DESELECT_ALL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_DESELECT_ALL.Location = new System.Drawing.Point(134, 74);
            this.BUTTON_DESELECT_ALL.Name = "BUTTON_DESELECT_ALL";
            this.BUTTON_DESELECT_ALL.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_DESELECT_ALL.TabIndex = 4;
            this.BUTTON_DESELECT_ALL.Tag = "BUTTON_DESELECT_ALL";
            this.BUTTON_DESELECT_ALL.Text = global::NicaBiometrics.Properties.Resources.LABEL_DESELECT_ALL;
            this.BUTTON_DESELECT_ALL.UseVisualStyleBackColor = true;
            this.BUTTON_DESELECT_ALL.Click += new System.EventHandler(this.BUTTON_DESELECT_ALL_Click);
            // 
            // BUTTON_SELECT_ALL
            // 
            this.BUTTON_SELECT_ALL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SELECT_ALL.Location = new System.Drawing.Point(52, 74);
            this.BUTTON_SELECT_ALL.Name = "BUTTON_SELECT_ALL";
            this.BUTTON_SELECT_ALL.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_SELECT_ALL.TabIndex = 3;
            this.BUTTON_SELECT_ALL.Tag = "BUTTON_SELECT_ALL";
            this.BUTTON_SELECT_ALL.Text = global::NicaBiometrics.Properties.Resources.LABEL_SELECT_ALL;
            this.BUTTON_SELECT_ALL.UseVisualStyleBackColor = true;
            this.BUTTON_SELECT_ALL.Click += new System.EventHandler(this.BUTTON_SELECT_ALL_Click);
            // 
            // VALUE_SEARCH_EMPLOYEE
            // 
            this.VALUE_SEARCH_EMPLOYEE.Location = new System.Drawing.Point(52, 47);
            this.VALUE_SEARCH_EMPLOYEE.Name = "VALUE_SEARCH_EMPLOYEE";
            this.VALUE_SEARCH_EMPLOYEE.Size = new System.Drawing.Size(199, 20);
            this.VALUE_SEARCH_EMPLOYEE.TabIndex = 2;
            this.VALUE_SEARCH_EMPLOYEE.Tag = "VALUE_SEARCH_EMPLOYEE";
            this.VALUE_SEARCH_EMPLOYEE.TextChanged += new System.EventHandler(this.VALUE_SEARCH_EMPLOYEE_TextChanged);
            this.VALUE_SEARCH_EMPLOYEE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VALUE_SEARCH_EMPLOYEE_KeyUp);
            // 
            // LIST_EMPLOYEES
            // 
            this.LIST_EMPLOYEES.CheckOnClick = true;
            this.LIST_EMPLOYEES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_EMPLOYEES.FormattingEnabled = true;
            this.LIST_EMPLOYEES.Location = new System.Drawing.Point(52, 108);
            this.LIST_EMPLOYEES.Name = "LIST_EMPLOYEES";
            this.LIST_EMPLOYEES.Size = new System.Drawing.Size(286, 277);
            this.LIST_EMPLOYEES.TabIndex = 1;
            this.LIST_EMPLOYEES.Tag = "LIST_EMPLOYEES";
            this.LIST_EMPLOYEES.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LIST_EMPLOYEES_ItemCheck);
            // 
            // SELECT_COMPANIES
            // 
            this.SELECT_COMPANIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SELECT_COMPANIES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SELECT_COMPANIES.FormattingEnabled = true;
            this.SELECT_COMPANIES.Location = new System.Drawing.Point(52, 15);
            this.SELECT_COMPANIES.Name = "SELECT_COMPANIES";
            this.SELECT_COMPANIES.Size = new System.Drawing.Size(286, 21);
            this.SELECT_COMPANIES.TabIndex = 0;
            this.SELECT_COMPANIES.Tag = "SELECT_COMPANIES";
            this.SELECT_COMPANIES.SelectedIndexChanged += new System.EventHandler(this.SELECT_COMPANIES_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TIME_LISTENER_LOG
            // 
            this.TIME_LISTENER_LOG.Interval = 1000;
            this.TIME_LISTENER_LOG.Tick += new System.EventHandler(this.TIME_LISTENER_LOG_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // PANEL_GDS
            // 
            this.PANEL_GDS.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_GDS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PANEL_GDS.BackgroundImage")));
            this.PANEL_GDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PANEL_GDS.Location = new System.Drawing.Point(29, 364);
            this.PANEL_GDS.Name = "PANEL_GDS";
            this.PANEL_GDS.Size = new System.Drawing.Size(61, 63);
            this.PANEL_GDS.TabIndex = 6;
            this.PANEL_GDS.Tag = "PANEL_GDS";
            // 
            // LABEL_NB
            // 
            this.LABEL_NB.AutoSize = true;
            this.LABEL_NB.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_NB.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NB.LinkColor = System.Drawing.Color.Red;
            this.LABEL_NB.Location = new System.Drawing.Point(23, 9);
            this.LABEL_NB.Name = "LABEL_NB";
            this.LABEL_NB.Size = new System.Drawing.Size(67, 35);
            this.LABEL_NB.TabIndex = 4;
            this.LABEL_NB.TabStop = true;
            this.LABEL_NB.Text = "NB";
            // 
            // APP_TRAY_ICON
            // 
            this.APP_TRAY_ICON.ContextMenuStrip = APP_CONTEXT_MENU;
            this.APP_TRAY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("APP_TRAY_ICON.Icon")));
            this.APP_TRAY_ICON.Text = "Nica Biometrics";
            this.APP_TRAY_ICON.Visible = true;
            this.APP_TRAY_ICON.DoubleClick += new System.EventHandler(this.APP_TRAY_ICON_DoubleClick);
            // 
            // TIME_EMPLOYEE
            // 
            this.TIME_EMPLOYEE.Tick += new System.EventHandler(this.TIME_EMPLOYEE_Tick);
            // 
            // TRAY_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(495, 439);
            this.Controls.Add(this.PANEL_GDS);
            this.Controls.Add(this.LABEL_NB);
            this.Controls.Add(this.TAB_FORM_TRAY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(511, 478);
            this.MinimumSize = new System.Drawing.Size(511, 478);
            this.Name = "TRAY_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "TRAY_FORM";
            this.Text = "Nica Biometrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TRAY_FORM_FormClosing);
            this.Load += new System.EventHandler(this.TRAY_FORM_Load);
            this.Move += new System.EventHandler(this.TRAY_FORM_Move);
            APP_CONTEXT_MENU.ResumeLayout(false);
            this.TAB_FORM_TRAY.ResumeLayout(false);
            this.TAB_DEVICE_SETTING.ResumeLayout(false);
            this.PANEL_DEVICE_NET_SETTING.ResumeLayout(false);
            this.PANEL_DEVICE_NET_SETTING.PerformLayout();
            this.TAB_SERVER_SETTING.ResumeLayout(false);
            this.PANEL_SERVER_SETTING.ResumeLayout(false);
            this.PANEL_SERVER_SETTING.PerformLayout();
            this.TAB_REMOTE_CONTROL.ResumeLayout(false);
            this.TAB_REMOTE_CONTROL.PerformLayout();
            this.TAB_COMPANY.ResumeLayout(false);
            this.TAB_EMPLOYEE.ResumeLayout(false);
            this.TAB_EMPLOYEE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_DEVICE_ADDRESS;
        private System.Windows.Forms.TextBox VALUE_DEVICE_ADDRESS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BUTTON_DEVICE_REFRESH;
        private System.Windows.Forms.TextBox VALUE_DEVICE_PORT;
        private System.Windows.Forms.Label LABEL_DEVICE_PORT;
        private System.Windows.Forms.Button BUTTON_CONNECT;
        private System.Windows.Forms.Panel PANEL_DEVICE_NET_SETTING;
        private System.Windows.Forms.LinkLabel LABEL_NB;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon APP_TRAY_ICON;
        private System.Windows.Forms.TabControl TAB_FORM_TRAY;
        private System.Windows.Forms.TabPage TAB_SERVER_SETTING;
        private System.Windows.Forms.TabPage TAB_DEVICE_SETTING;
        private System.Windows.Forms.Panel PANEL_SERVER_SETTING;
        private System.Windows.Forms.Button BUTTON_REFRESH_SERVER;
        private System.Windows.Forms.Button BUTTON_CONNECT_SERVER;
        private System.Windows.Forms.Label LABEL_SERVER_IPADDRESS;
        private System.Windows.Forms.TextBox VALUE_SERVER_ADDRESS;
        private System.Windows.Forms.CheckBox CHECK_VIA_NET;
        private System.Windows.Forms.CheckBox CHECK_VIA_USB;
        private System.Windows.Forms.Button BUTTON_REFRESH_USB_LIST;
        private System.Windows.Forms.ListBox LIST_DEVICE_HARDWARE;
        private System.Windows.Forms.TextBox VALUE_COMM_KEY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LABEL_COMM_KEY;
        private System.Windows.Forms.Label LABEL_DEVICE_ID;
        private System.Windows.Forms.TextBox VALUE_DEVICE_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BUTTON_CLEAR_LOGS;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.TabPage TAB_REMOTE_CONTROL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LABEL_DEVICE_NAME;
        private System.Windows.Forms.TextBox VALUE_DEVICE_NAME;
        private System.Windows.Forms.Label LABEL_SERIAL;
        private System.Windows.Forms.TextBox VALUE_SERIAL;
        private System.Windows.Forms.Button BUTTON_RESTART;
        private System.Windows.Forms.TextBox VALUE_MAC_ADD;
        private System.Windows.Forms.Label LABEL_MAC_ADDRESS;
        private System.Windows.Forms.TextBox VALUE_BIOTMETRIC_TYPE;
        private System.Windows.Forms.Label LABEL_BIOMETRIC_TYPE;
        private System.Windows.Forms.Timer TIME_LISTENER_LOG;
        private System.Windows.Forms.TextBox VALUE_TIMEOUT_URL;
        private System.Windows.Forms.TextBox VALUE_TIMEIN_URL;
        private System.Windows.Forms.Label LABEL_TIMEOUT_URL;
        private System.Windows.Forms.Label LABEL_TIMEIN_URL;
        private System.Windows.Forms.Label LABEL_EMPLOYEE_URL;
        private System.Windows.Forms.TextBox VALUE_EMPLOYEE_URL;
        private System.Windows.Forms.Button BUTTON_CLEAR_SERVER_LOGS;
        private System.Windows.Forms.ListBox LIST_SERVER_LOGS;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel PANEL_GDS;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.TextBox VALUE_COMPANY_URL;
        private System.Windows.Forms.Label LABEL_COMPANY_URL;
        private System.Windows.Forms.TabPage TAB_COMPANY;
        private System.Windows.Forms.Button BUTTON_ADD_COMPANY;
        private System.Windows.Forms.CheckedListBox LIST_COMPANIES;
        private System.Windows.Forms.Button BUTTON_REMOVE_COMPANY;
        private System.Windows.Forms.TabPage TAB_EMPLOYEE;
        private System.Windows.Forms.ComboBox SELECT_COMPANIES;
        private System.Windows.Forms.ProgressBar PROGRESS_EMPLOYEE;
        private System.Windows.Forms.Button BUTTON_SEARCH_EMPLOYEE;
        private System.Windows.Forms.Button BUTTON_DESELECT_ALL;
        private System.Windows.Forms.Button BUTTON_SELECT_ALL;
        private System.Windows.Forms.TextBox VALUE_SEARCH_EMPLOYEE;
        private System.Windows.Forms.CheckedListBox LIST_EMPLOYEES;
        private System.Windows.Forms.Timer TIME_EMPLOYEE;
        private System.Windows.Forms.Button BUTTON_SAVE_EMPLOYEES;
    }
}