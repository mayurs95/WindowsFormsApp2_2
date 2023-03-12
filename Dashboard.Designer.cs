namespace WindowsFormsApp2
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_inword_outword_dashboard = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_reports_dashboard = new System.Windows.Forms.Button();
            this.btn_masterdata_dashboard = new System.Windows.Forms.Button();
            this.btn_transaction_dashboard = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailAddressToolStripMenuItem,
            this.phoneNumberToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // emailAddressToolStripMenuItem
            // 
            this.emailAddressToolStripMenuItem.Name = "emailAddressToolStripMenuItem";
            this.emailAddressToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.emailAddressToolStripMenuItem.Text = "Email Address";
            // 
            // phoneNumberToolStripMenuItem
            // 
            this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
            this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.phoneNumberToolStripMenuItem.Text = "Phone Number";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(1291, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 24);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.btn_inword_outword_dashboard);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btn_reports_dashboard);
            this.panel1.Controls.Add(this.btn_masterdata_dashboard);
            this.panel1.Controls.Add(this.btn_transaction_dashboard);
            this.panel1.Controls.Add(this.btn_registration);
            this.panel1.Controls.Add(this.btn_inventory);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 581);
            this.panel1.TabIndex = 2;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 525);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(218, 43);
            this.button11.TabIndex = 9;
            this.button11.Text = "Other";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 467);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(218, 43);
            this.button10.TabIndex = 8;
            this.button10.Text = "Help!";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(0, 409);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(218, 43);
            this.button9.TabIndex = 7;
            this.button9.Text = "Notes";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btn_inword_outword_dashboard
            // 
            this.btn_inword_outword_dashboard.Location = new System.Drawing.Point(0, 351);
            this.btn_inword_outword_dashboard.Name = "btn_inword_outword_dashboard";
            this.btn_inword_outword_dashboard.Size = new System.Drawing.Size(218, 43);
            this.btn_inword_outword_dashboard.TabIndex = 6;
            this.btn_inword_outword_dashboard.Text = "Inword Outword";
            this.btn_inword_outword_dashboard.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 43);
            this.button7.TabIndex = 5;
            this.button7.Text = "Finance";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_reports_dashboard
            // 
            this.btn_reports_dashboard.Location = new System.Drawing.Point(0, 234);
            this.btn_reports_dashboard.Name = "btn_reports_dashboard";
            this.btn_reports_dashboard.Size = new System.Drawing.Size(218, 43);
            this.btn_reports_dashboard.TabIndex = 4;
            this.btn_reports_dashboard.Text = "Reports";
            this.btn_reports_dashboard.UseVisualStyleBackColor = true;
            this.btn_reports_dashboard.Click += new System.EventHandler(this.btn_reports_dashboard_Click);
            // 
            // btn_masterdata_dashboard
            // 
            this.btn_masterdata_dashboard.Location = new System.Drawing.Point(0, 176);
            this.btn_masterdata_dashboard.Name = "btn_masterdata_dashboard";
            this.btn_masterdata_dashboard.Size = new System.Drawing.Size(218, 43);
            this.btn_masterdata_dashboard.TabIndex = 3;
            this.btn_masterdata_dashboard.Text = "Master Data";
            this.btn_masterdata_dashboard.UseVisualStyleBackColor = true;
            this.btn_masterdata_dashboard.Click += new System.EventHandler(this.btn_masterdata_dashboard_Click);
            // 
            // btn_transaction_dashboard
            // 
            this.btn_transaction_dashboard.Location = new System.Drawing.Point(0, 116);
            this.btn_transaction_dashboard.Name = "btn_transaction_dashboard";
            this.btn_transaction_dashboard.Size = new System.Drawing.Size(218, 43);
            this.btn_transaction_dashboard.TabIndex = 2;
            this.btn_transaction_dashboard.Text = "Transactions";
            this.btn_transaction_dashboard.UseVisualStyleBackColor = true;
            this.btn_transaction_dashboard.Click += new System.EventHandler(this.btn_transaction_dashboard_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.Location = new System.Drawing.Point(0, 58);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(218, 43);
            this.btn_registration.TabIndex = 1;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Location = new System.Drawing.Point(0, 0);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(218, 43);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 32);
            this.textBox1.TabIndex = 3;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 42);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 32);
            this.button12.TabIndex = 4;
            this.button12.Text = "Search :";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 32);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2023 NeoVortex. All rights reserved.";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_inword_outword_dashboard;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_reports_dashboard;
        private System.Windows.Forms.Button btn_masterdata_dashboard;
        private System.Windows.Forms.Button btn_transaction_dashboard;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}