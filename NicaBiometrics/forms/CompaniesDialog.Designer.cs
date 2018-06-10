using System.Windows.Forms;

namespace NicaBiometrics.forms
{
    partial class CompaniesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesDialog));
            this.VALUE_FIND_COMPANY = new System.Windows.Forms.TextBox();
            this.BUTTON_SEARCH_COMPANY = new System.Windows.Forms.Button();
            this.LIST_COMPANIES = new System.Windows.Forms.CheckedListBox();
            this.BUTTON_CANCEL = new System.Windows.Forms.Button();
            this.BUTTON_SAVE = new System.Windows.Forms.Button();
            this.TIME_PROGRESS = new System.Windows.Forms.Timer(this.components);
            this.PROGRESS_SEARCH = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // VALUE_FIND_COMPANY
            // 
            this.VALUE_FIND_COMPANY.Location = new System.Drawing.Point(58, 58);
            this.VALUE_FIND_COMPANY.Name = "VALUE_FIND_COMPANY";
            this.VALUE_FIND_COMPANY.Size = new System.Drawing.Size(234, 20);
            this.VALUE_FIND_COMPANY.TabIndex = 0;
            this.VALUE_FIND_COMPANY.Tag = "VALUE_FIND_COMPANY";
            this.VALUE_FIND_COMPANY.TextChanged += new System.EventHandler(this.VALUE_FIND_COMPANY_TextChanged);
            this.VALUE_FIND_COMPANY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VALUE_FIND_COMPANY_KeyUp);
            // 
            // BUTTON_SEARCH_COMPANY
            // 
            this.BUTTON_SEARCH_COMPANY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SEARCH_COMPANY.Location = new System.Drawing.Point(298, 52);
            this.BUTTON_SEARCH_COMPANY.Name = "BUTTON_SEARCH_COMPANY";
            this.BUTTON_SEARCH_COMPANY.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_SEARCH_COMPANY.TabIndex = 1;
            this.BUTTON_SEARCH_COMPANY.Tag = "BUTTON_SEARCH_COMPANY";
            this.BUTTON_SEARCH_COMPANY.Text = global::NicaBiometrics.Properties.Resources.LABEL_SEARCH;
            this.BUTTON_SEARCH_COMPANY.UseVisualStyleBackColor = true;
            this.BUTTON_SEARCH_COMPANY.Click += new System.EventHandler(this.BUTTON_SEARCH_COMPANY_Click);
            // 
            // LIST_COMPANIES
            // 
            this.LIST_COMPANIES.CheckOnClick = true;
            this.LIST_COMPANIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_COMPANIES.FormattingEnabled = true;
            this.LIST_COMPANIES.Location = new System.Drawing.Point(58, 84);
            this.LIST_COMPANIES.Name = "LIST_COMPANIES";
            this.LIST_COMPANIES.Size = new System.Drawing.Size(315, 256);
            this.LIST_COMPANIES.TabIndex = 2;
            this.LIST_COMPANIES.Tag = "LIST_COMPANIES";
            this.LIST_COMPANIES.ThreeDCheckBoxes = true;
            // 
            // BUTTON_CANCEL
            // 
            this.BUTTON_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CANCEL.Location = new System.Drawing.Point(139, 353);
            this.BUTTON_CANCEL.Name = "BUTTON_CANCEL";
            this.BUTTON_CANCEL.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_CANCEL.TabIndex = 4;
            this.BUTTON_CANCEL.Tag = "BUTTON_CANCEL";
            this.BUTTON_CANCEL.Text = global::NicaBiometrics.Properties.Resources.LABEL_CANCEL;
            this.BUTTON_CANCEL.UseVisualStyleBackColor = true;
            this.BUTTON_CANCEL.Click += new System.EventHandler(this.BUTTON_CANCEL_Click);
            // 
            // BUTTON_SAVE
            // 
            this.BUTTON_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SAVE.Location = new System.Drawing.Point(58, 353);
            this.BUTTON_SAVE.Name = "BUTTON_SAVE";
            this.BUTTON_SAVE.Size = new System.Drawing.Size(75, 30);
            this.BUTTON_SAVE.TabIndex = 5;
            this.BUTTON_SAVE.Tag = "BUTTON_SAVE";
            this.BUTTON_SAVE.Text = global::NicaBiometrics.Properties.Resources.LABEL_SAVE;
            this.BUTTON_SAVE.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE.Click += new System.EventHandler(this.BUTTON_SAVE_Click);
            // 
            // TIME_PROGRESS
            // 
            this.TIME_PROGRESS.Tag = "TIME_PROGRESS";
            this.TIME_PROGRESS.Tick += new System.EventHandler(this.TIME_PROGRESS_Tick);
            // 
            // PROGRESS_SEARCH
            // 
            this.PROGRESS_SEARCH.Location = new System.Drawing.Point(58, 26);
            this.PROGRESS_SEARCH.Name = "PROGRESS_SEARCH";
            this.PROGRESS_SEARCH.Size = new System.Drawing.Size(315, 20);
            this.PROGRESS_SEARCH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PROGRESS_SEARCH.TabIndex = 6;
            this.PROGRESS_SEARCH.Tag = "PROGRESS_SEARCH";
            // 
            // CompaniesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NicaBiometrics.Properties.Resources.search_header;
            this.ClientSize = new System.Drawing.Size(395, 395);
            this.Controls.Add(this.PROGRESS_SEARCH);
            this.Controls.Add(this.BUTTON_SAVE);
            this.Controls.Add(this.BUTTON_CANCEL);
            this.Controls.Add(this.LIST_COMPANIES);
            this.Controls.Add(this.BUTTON_SEARCH_COMPANY);
            this.Controls.Add(this.VALUE_FIND_COMPANY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompaniesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.CompaniesDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VALUE_FIND_COMPANY;
        private System.Windows.Forms.Button BUTTON_SEARCH_COMPANY;
        private System.Windows.Forms.CheckedListBox LIST_COMPANIES;
        private System.Windows.Forms.Button BUTTON_CANCEL;
        private System.Windows.Forms.Button BUTTON_SAVE;
        private System.Windows.Forms.Timer TIME_PROGRESS;
        private System.Windows.Forms.ProgressBar PROGRESS_SEARCH;
    }
}