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
            this.VALUE_COMPANY = new System.Windows.Forms.TextBox();
            this.LABEL_COMPANY = new System.Windows.Forms.Label();
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
            this.BUTTON_CLEAR_EMPLOYEE_LOG = new System.Windows.Forms.Button();
            this.LIST_EMPLOYEE_LOG = new System.Windows.Forms.ListBox();
            this.PROGRESS_EMPLOYEE = new System.Windows.Forms.ProgressBar();
            this.BUTTON_UPDATE_EMPLOYEE = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TIME_LISTENER_LOG = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PANEL_GDS = new System.Windows.Forms.Panel();
            this.LABEL_NB = new System.Windows.Forms.LinkLabel();
            this.APP_TRAY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            APP_CONTEXT_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            APP_CONTEXT_MENU.SuspendLayout();
            this.TAB_FORM_TRAY.SuspendLayout();
            this.TAB_DEVICE_SETTING.SuspendLayout();
            this.PANEL_DEVICE_NET_SETTING.SuspendLayout();
            this.TAB_SERVER_SETTING.SuspendLayout();
            this.PANEL_SERVER_SETTING.SuspendLayout();
            this.TAB_REMOTE_CONTROL.SuspendLayout();
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
            this.TAB_DEVICE_SETTING.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_DEVICE_SETTING;
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
            this.LABEL_DEVICE_ID.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_DEVICE_ID;
            // 
            // LABEL_COMM_KEY
            // 
            this.LABEL_COMM_KEY.AutoSize = true;
            this.LABEL_COMM_KEY.Location = new System.Drawing.Point(49, 202);
            this.LABEL_COMM_KEY.Name = "LABEL_COMM_KEY";
            this.LABEL_COMM_KEY.Size = new System.Drawing.Size(56, 13);
            this.LABEL_COMM_KEY.TabIndex = 13;
            this.LABEL_COMM_KEY.Tag = "LABEL_COMM_KEY";
            this.LABEL_COMM_KEY.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_COMM_KEY;
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
            this.BUTTON_REFRESH_USB_LIST.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_REFRESH;
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
            this.CHECK_VIA_USB.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECT_VIA_USB;
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
            this.CHECK_VIA_NET.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECT_VIA_NETWORK;
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
            this.BUTTON_CONNECT.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECT;
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
            this.BUTTON_DEVICE_REFRESH.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_REFRESH;
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
            this.LABEL_DEVICE_PORT.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_PORT;
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
            this.LABEL_DEVICE_ADDRESS.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_DEVICE_ADDRESS;
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
            this.TAB_SERVER_SETTING.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_SERVER_SETTING;
            // 
            // PANEL_SERVER_SETTING
            // 
            this.PANEL_SERVER_SETTING.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_SERVER_SETTING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_COMPANY);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_COMPANY);
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
            // VALUE_COMPANY
            // 
            this.VALUE_COMPANY.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NicaBiometrics.Properties.Settings.Default, "_serverCompany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VALUE_COMPANY.Location = new System.Drawing.Point(111, 19);
            this.VALUE_COMPANY.Name = "VALUE_COMPANY";
            this.VALUE_COMPANY.Size = new System.Drawing.Size(190, 20);
            this.VALUE_COMPANY.TabIndex = 23;
            this.VALUE_COMPANY.Tag = "VALUE_COMPANY";
            this.VALUE_COMPANY.Text = global::NicaBiometrics.Properties.Settings.Default._serverCompany;
            this.VALUE_COMPANY.TextChanged += new System.EventHandler(this.VALUE_COMPANY_TextChanged);
            // 
            // LABEL_COMPANY
            // 
            this.LABEL_COMPANY.AutoSize = true;
            this.LABEL_COMPANY.Location = new System.Drawing.Point(54, 22);
            this.LABEL_COMPANY.Name = "LABEL_COMPANY";
            this.LABEL_COMPANY.Size = new System.Drawing.Size(51, 13);
            this.LABEL_COMPANY.TabIndex = 22;
            this.LABEL_COMPANY.Tag = "LABEL_COMPANY";
            this.LABEL_COMPANY.Text = "Company";
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
            this.VALUE_SERVER_ADDRESS.Location = new System.Drawing.Point(111, 49);
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
            this.BUTTON_REFRESH_SERVER.Location = new System.Drawing.Point(263, 75);
            this.BUTTON_REFRESH_SERVER.Name = "BUTTON_REFRESH_SERVER";
            this.BUTTON_REFRESH_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_REFRESH_SERVER.TabIndex = 12;
            this.BUTTON_REFRESH_SERVER.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_REFRESH;
            this.BUTTON_REFRESH_SERVER.UseVisualStyleBackColor = false;
            this.BUTTON_REFRESH_SERVER.Click += new System.EventHandler(this.BUTTON_REFRESH_SERVER_Click);
            // 
            // BUTTON_CONNECT_SERVER
            // 
            this.BUTTON_CONNECT_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CONNECT_SERVER.Location = new System.Drawing.Point(182, 75);
            this.BUTTON_CONNECT_SERVER.Name = "BUTTON_CONNECT_SERVER";
            this.BUTTON_CONNECT_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_CONNECT_SERVER.TabIndex = 11;
            this.BUTTON_CONNECT_SERVER.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECT;
            this.BUTTON_CONNECT_SERVER.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT_SERVER.Click += new System.EventHandler(this.BUTTON_CONNECT_SERVER_Click);
            // 
            // LABEL_SERVER_IPADDRESS
            // 
            this.LABEL_SERVER_IPADDRESS.AutoSize = true;
            this.LABEL_SERVER_IPADDRESS.Location = new System.Drawing.Point(27, 52);
            this.LABEL_SERVER_IPADDRESS.Name = "LABEL_SERVER_IPADDRESS";
            this.LABEL_SERVER_IPADDRESS.Size = new System.Drawing.Size(78, 13);
            this.LABEL_SERVER_IPADDRESS.TabIndex = 2;
            this.LABEL_SERVER_IPADDRESS.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_SERVER_IPADDRESS;
            // 
            // TAB_REMOTE_CONTROL
            // 
            this.TAB_REMOTE_CONTROL.BackColor = System.Drawing.Color.OldLace;
            this.TAB_REMOTE_CONTROL.Controls.Add(this.BUTTON_CLEAR_EMPLOYEE_LOG);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.LIST_EMPLOYEE_LOG);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.PROGRESS_EMPLOYEE);
            this.TAB_REMOTE_CONTROL.Controls.Add(this.BUTTON_UPDATE_EMPLOYEE);
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
            // BUTTON_CLEAR_EMPLOYEE_LOG
            // 
            this.BUTTON_CLEAR_EMPLOYEE_LOG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CLEAR_EMPLOYEE_LOG.Location = new System.Drawing.Point(52, 230);
            this.BUTTON_CLEAR_EMPLOYEE_LOG.Name = "BUTTON_CLEAR_EMPLOYEE_LOG";
            this.BUTTON_CLEAR_EMPLOYEE_LOG.Size = new System.Drawing.Size(68, 30);
            this.BUTTON_CLEAR_EMPLOYEE_LOG.TabIndex = 14;
            this.BUTTON_CLEAR_EMPLOYEE_LOG.Tag = "BUTTON_CLEAR_EMPLOYEE_LOG";
            this.BUTTON_CLEAR_EMPLOYEE_LOG.Text = global::NicaBiometrics.Properties.Resources.LABEL_CLEAR_LOGS;
            this.BUTTON_CLEAR_EMPLOYEE_LOG.UseVisualStyleBackColor = true;
            // 
            // LIST_EMPLOYEE_LOG
            // 
            this.LIST_EMPLOYEE_LOG.BackColor = System.Drawing.SystemColors.MenuText;
            this.LIST_EMPLOYEE_LOG.ForeColor = System.Drawing.SystemColors.Window;
            this.LIST_EMPLOYEE_LOG.FormattingEnabled = true;
            this.LIST_EMPLOYEE_LOG.Location = new System.Drawing.Point(52, 266);
            this.LIST_EMPLOYEE_LOG.Name = "LIST_EMPLOYEE_LOG";
            this.LIST_EMPLOYEE_LOG.Size = new System.Drawing.Size(286, 121);
            this.LIST_EMPLOYEE_LOG.TabIndex = 13;
            this.LIST_EMPLOYEE_LOG.Tag = "LIST_EMPLOYEE_LOG";
            // 
            // PROGRESS_EMPLOYEE
            // 
            this.PROGRESS_EMPLOYEE.Location = new System.Drawing.Point(52, 393);
            this.PROGRESS_EMPLOYEE.Name = "PROGRESS_EMPLOYEE";
            this.PROGRESS_EMPLOYEE.Size = new System.Drawing.Size(286, 15);
            this.PROGRESS_EMPLOYEE.TabIndex = 12;
            this.PROGRESS_EMPLOYEE.Tag = "PROGRESS_EMPLOYEE";
            // 
            // BUTTON_UPDATE_EMPLOYEE
            // 
            this.BUTTON_UPDATE_EMPLOYEE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_UPDATE_EMPLOYEE.Location = new System.Drawing.Point(233, 129);
            this.BUTTON_UPDATE_EMPLOYEE.Name = "BUTTON_UPDATE_EMPLOYEE";
            this.BUTTON_UPDATE_EMPLOYEE.Size = new System.Drawing.Size(125, 30);
            this.BUTTON_UPDATE_EMPLOYEE.TabIndex = 11;
            this.BUTTON_UPDATE_EMPLOYEE.Tag = "BUTTON_UPDATE_EMPLOYEE";
            this.BUTTON_UPDATE_EMPLOYEE.Text = global::NicaBiometrics.Properties.Resources.LABEL_UPDATE_EMPLOYEE_RECORD;
            this.BUTTON_UPDATE_EMPLOYEE.UseVisualStyleBackColor = true;
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
            this.VALUE_DEVICE_NAME.Text = global::NicaBiometrics.Properties.Settings.Default.VALUE_DEVICE_NAME;
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
            this.LABEL_NB.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_NB;
            // 
            // APP_TRAY_ICON
            // 
            this.APP_TRAY_ICON.ContextMenuStrip = APP_CONTEXT_MENU;
            this.APP_TRAY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("APP_TRAY_ICON.Icon")));
            this.APP_TRAY_ICON.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_APP_NAME;
            this.APP_TRAY_ICON.Visible = true;
            this.APP_TRAY_ICON.DoubleClick += new System.EventHandler(this.APP_TRAY_ICON_DoubleClick);
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
        private System.Windows.Forms.Button BUTTON_UPDATE_EMPLOYEE;
        private System.Windows.Forms.Label LABEL_COMPANY;
        private System.Windows.Forms.TextBox VALUE_COMPANY;
        private System.Windows.Forms.ProgressBar PROGRESS_EMPLOYEE;
        private System.Windows.Forms.ListBox LIST_EMPLOYEE_LOG;
        private System.Windows.Forms.Button BUTTON_CLEAR_EMPLOYEE_LOG;
        private System.Windows.Forms.Panel PANEL_GDS;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}