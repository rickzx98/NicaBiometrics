namespace NicaBiometrics.forms
{
    partial class ConnectingToDeviceProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectingToDeviceProcessForm));
            this.PROGRESS_CONNECTING_TO_DEVICE = new System.Windows.Forms.ProgressBar();
            this.LABEL_CONNECTING_TO_DEVICE = new System.Windows.Forms.Label();
            this.TIMER_PROGRESS_TICK = new System.Windows.Forms.Timer(this.components);
            this.LABEL_NB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PROGRESS_CONNECTING_TO_DEVICE
            // 
            this.PROGRESS_CONNECTING_TO_DEVICE.Location = new System.Drawing.Point(90, 61);
            this.PROGRESS_CONNECTING_TO_DEVICE.Name = "PROGRESS_CONNECTING_TO_DEVICE";
            this.PROGRESS_CONNECTING_TO_DEVICE.Size = new System.Drawing.Size(289, 23);
            this.PROGRESS_CONNECTING_TO_DEVICE.Step = 1;
            this.PROGRESS_CONNECTING_TO_DEVICE.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PROGRESS_CONNECTING_TO_DEVICE.TabIndex = 1;
            this.PROGRESS_CONNECTING_TO_DEVICE.Tag = "PROGRESS_CONNECTING_TO_DEVICE";
            // 
            // LABEL_CONNECTING_TO_DEVICE
            // 
            this.LABEL_CONNECTING_TO_DEVICE.AutoSize = true;
            this.LABEL_CONNECTING_TO_DEVICE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_CONNECTING_TO_DEVICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CONNECTING_TO_DEVICE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LABEL_CONNECTING_TO_DEVICE.Location = new System.Drawing.Point(93, 39);
            this.LABEL_CONNECTING_TO_DEVICE.Name = "LABEL_CONNECTING_TO_DEVICE";
            this.LABEL_CONNECTING_TO_DEVICE.Size = new System.Drawing.Size(169, 20);
            this.LABEL_CONNECTING_TO_DEVICE.TabIndex = 0;
            this.LABEL_CONNECTING_TO_DEVICE.Tag = "LABEL_CONNECTING_TO_DEVICE";
            this.LABEL_CONNECTING_TO_DEVICE.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_CONNECTING_TO_DEVICE;
            // 
            // TIMER_PROGRESS_TICK
            // 
            this.TIMER_PROGRESS_TICK.Tick += new System.EventHandler(this.TIMER_PROGRESS_TICK_Tick);
            // 
            // LABEL_NB
            // 
            this.LABEL_NB.AutoSize = true;
            this.LABEL_NB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LABEL_NB.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NB.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LABEL_NB.Location = new System.Drawing.Point(12, 43);
            this.LABEL_NB.Name = "LABEL_NB";
            this.LABEL_NB.Size = new System.Drawing.Size(67, 35);
            this.LABEL_NB.TabIndex = 5;
            this.LABEL_NB.TabStop = true;
            this.LABEL_NB.Text = global::NicaBiometrics.Properties.Settings.Default.LABEL_NB;
            // 
            // ConnectingToDeviceProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 125);
            this.ControlBox = false;
            this.Controls.Add(this.LABEL_NB);
            this.Controls.Add(this.PROGRESS_CONNECTING_TO_DEVICE);
            this.Controls.Add(this.LABEL_CONNECTING_TO_DEVICE);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectingToDeviceProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectingToDeviceProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_CONNECTING_TO_DEVICE;
        private System.Windows.Forms.Timer TIMER_PROGRESS_TICK;
        private System.Windows.Forms.ProgressBar PROGRESS_CONNECTING_TO_DEVICE;
        private System.Windows.Forms.LinkLabel LABEL_NB;
    }
}