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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.VALUE_SERVER_PORT = new System.Windows.Forms.TextBox();
            this.VALUE_SERVER_ADDRESS = new System.Windows.Forms.TextBox();
            this.BUTTON_REFRESH_SERVER = new System.Windows.Forms.Button();
            this.BUTTON_CONNECT_SERVER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL_SERVER_IPADDRESS = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LABEL_NB = new System.Windows.Forms.LinkLabel();
            this.APP_TRAY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            APP_CONTEXT_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
            APP_CONTEXT_MENU.SuspendLayout();
            this.TAB_FORM_TRAY.SuspendLayout();
            this.TAB_DEVICE_SETTING.SuspendLayout();
            this.PANEL_DEVICE_NET_SETTING.SuspendLayout();
            this.TAB_SERVER_SETTING.SuspendLayout();
            this.PANEL_SERVER_SETTING.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // APP_CONTEXT_MENU
            // 
            APP_CONTEXT_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            APP_CONTEXT_MENU.Name = "APPI_CONTEXT_MENU";
            APP_CONTEXT_MENU.Size = new System.Drawing.Size(181, 92);
            APP_CONTEXT_MENU.Click += new System.EventHandler(this.APP_CONTEXT_MENU_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.TAB_FORM_TRAY.Location = new System.Drawing.Point(79, 12);
            this.TAB_FORM_TRAY.Name = "TAB_FORM_TRAY";
            this.TAB_FORM_TRAY.SelectedIndex = 0;
            this.TAB_FORM_TRAY.Size = new System.Drawing.Size(382, 421);
            this.TAB_FORM_TRAY.TabIndex = 5;
            // 
            // TAB_DEVICE_SETTING
            // 
            this.TAB_DEVICE_SETTING.BackColor = System.Drawing.Color.OldLace;
            this.TAB_DEVICE_SETTING.Controls.Add(this.PANEL_DEVICE_NET_SETTING);
            this.TAB_DEVICE_SETTING.Location = new System.Drawing.Point(4, 22);
            this.TAB_DEVICE_SETTING.Name = "TAB_DEVICE_SETTING";
            this.TAB_DEVICE_SETTING.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_DEVICE_SETTING.Size = new System.Drawing.Size(374, 395);
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
            this.PANEL_DEVICE_NET_SETTING.Size = new System.Drawing.Size(371, 395);
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
            this.LIST_DEVICE_HARDWARE.Size = new System.Drawing.Size(286, 121);
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
            this.VALUE_DEVICE_ADDRESS.Size = new System.Drawing.Size(227, 20);
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
            this.TAB_SERVER_SETTING.Size = new System.Drawing.Size(374, 395);
            this.TAB_SERVER_SETTING.TabIndex = 1;
            this.TAB_SERVER_SETTING.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_SERVER_SETTING;
            // 
            // PANEL_SERVER_SETTING
            // 
            this.PANEL_SERVER_SETTING.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_SERVER_SETTING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_SERVER_PORT);
            this.PANEL_SERVER_SETTING.Controls.Add(this.VALUE_SERVER_ADDRESS);
            this.PANEL_SERVER_SETTING.Controls.Add(this.BUTTON_REFRESH_SERVER);
            this.PANEL_SERVER_SETTING.Controls.Add(this.BUTTON_CONNECT_SERVER);
            this.PANEL_SERVER_SETTING.Controls.Add(this.label1);
            this.PANEL_SERVER_SETTING.Controls.Add(this.LABEL_SERVER_IPADDRESS);
            this.PANEL_SERVER_SETTING.Location = new System.Drawing.Point(0, 0);
            this.PANEL_SERVER_SETTING.Name = "PANEL_SERVER_SETTING";
            this.PANEL_SERVER_SETTING.Size = new System.Drawing.Size(371, 364);
            this.PANEL_SERVER_SETTING.TabIndex = 9;
            // 
            // VALUE_SERVER_PORT
            // 
            this.VALUE_SERVER_PORT.Location = new System.Drawing.Point(111, 38);
            this.VALUE_SERVER_PORT.Name = "VALUE_SERVER_PORT";
            this.VALUE_SERVER_PORT.Size = new System.Drawing.Size(106, 20);
            this.VALUE_SERVER_PORT.TabIndex = 14;
            this.VALUE_SERVER_PORT.Tag = "VALUE_SERVER_PORT";
            // 
            // VALUE_SERVER_ADDRESS
            // 
            this.VALUE_SERVER_ADDRESS.Location = new System.Drawing.Point(111, 12);
            this.VALUE_SERVER_ADDRESS.Name = "VALUE_SERVER_ADDRESS";
            this.VALUE_SERVER_ADDRESS.Size = new System.Drawing.Size(227, 20);
            this.VALUE_SERVER_ADDRESS.TabIndex = 13;
            this.VALUE_SERVER_ADDRESS.Tag = "VALUE_SERVER_ADDRESS";
            this.VALUE_SERVER_ADDRESS.TextChanged += new System.EventHandler(this.VALUE_SERVER_ADDRESS_TextChanged);
            // 
            // BUTTON_REFRESH_SERVER
            // 
            this.BUTTON_REFRESH_SERVER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BUTTON_REFRESH_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_REFRESH_SERVER.Location = new System.Drawing.Point(263, 64);
            this.BUTTON_REFRESH_SERVER.Name = "BUTTON_REFRESH_SERVER";
            this.BUTTON_REFRESH_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_REFRESH_SERVER.TabIndex = 12;
            this.BUTTON_REFRESH_SERVER.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_REFRESH;
            this.BUTTON_REFRESH_SERVER.UseVisualStyleBackColor = false;
            // 
            // BUTTON_CONNECT_SERVER
            // 
            this.BUTTON_CONNECT_SERVER.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CONNECT_SERVER.Location = new System.Drawing.Point(182, 64);
            this.BUTTON_CONNECT_SERVER.Name = "BUTTON_CONNECT_SERVER";
            this.BUTTON_CONNECT_SERVER.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_CONNECT_SERVER.TabIndex = 11;
            this.BUTTON_CONNECT_SERVER.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECT;
            this.BUTTON_CONNECT_SERVER.UseVisualStyleBackColor = true;
            this.BUTTON_CONNECT_SERVER.Click += new System.EventHandler(this.BUTTON_CONNECT_SERVER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_PORT;
            // 
            // LABEL_SERVER_IPADDRESS
            // 
            this.LABEL_SERVER_IPADDRESS.AutoSize = true;
            this.LABEL_SERVER_IPADDRESS.Location = new System.Drawing.Point(10, 15);
            this.LABEL_SERVER_IPADDRESS.Name = "LABEL_SERVER_IPADDRESS";
            this.LABEL_SERVER_IPADDRESS.Size = new System.Drawing.Size(92, 13);
            this.LABEL_SERVER_IPADDRESS.TabIndex = 2;
            this.LABEL_SERVER_IPADDRESS.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_SERVER_IPADDRESS;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LABEL_NB
            // 
            this.LABEL_NB.AutoSize = true;
            this.LABEL_NB.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_NB.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NB.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_NB.Location = new System.Drawing.Point(12, 7);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // TRAY_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(495, 439);
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
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon APP_TRAY_ICON;
        private System.Windows.Forms.TabControl TAB_FORM_TRAY;
        private System.Windows.Forms.TabPage TAB_SERVER_SETTING;
        private System.Windows.Forms.TabPage TAB_DEVICE_SETTING;
        private System.Windows.Forms.Panel PANEL_SERVER_SETTING;
        private System.Windows.Forms.Button BUTTON_REFRESH_SERVER;
        private System.Windows.Forms.Button BUTTON_CONNECT_SERVER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL_SERVER_IPADDRESS;
        private System.Windows.Forms.TextBox VALUE_SERVER_ADDRESS;
        private System.Windows.Forms.TextBox VALUE_SERVER_PORT;
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
    }
}