namespace WindowsFormsApp2
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_registration = new System.Windows.Forms.Button();
            this.btn_companyname = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_vendor = new System.Windows.Forms.Button();
            this.btn_medicinestock = new System.Windows.Forms.Button();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistrationGridView = new System.Windows.Forms.DataGridView();
            this.btn_hospital_registration = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_Content_registration = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationGridView)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 32);
            this.panel2.TabIndex = 11;
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
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Content_registration);
            this.panel1.Controls.Add(this.btn_category);
            this.panel1.Controls.Add(this.btn_hospital_registration);
            this.panel1.Controls.Add(this.btn_back_registration);
            this.panel1.Controls.Add(this.btn_companyname);
            this.panel1.Controls.Add(this.btn_patient);
            this.panel1.Controls.Add(this.btn_doctor);
            this.panel1.Controls.Add(this.btn_vendor);
            this.panel1.Controls.Add(this.btn_medicinestock);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 542);
            this.panel1.TabIndex = 8;
            // 
            // btn_back_registration
            // 
            this.btn_back_registration.Location = new System.Drawing.Point(0, 474);
            this.btn_back_registration.Name = "btn_back_registration";
            this.btn_back_registration.Size = new System.Drawing.Size(218, 43);
            this.btn_back_registration.TabIndex = 5;
            this.btn_back_registration.Text = "Back";
            this.btn_back_registration.UseVisualStyleBackColor = true;
            this.btn_back_registration.Click += new System.EventHandler(this.btn_back_registration_Click);
            // 
            // btn_companyname
            // 
            this.btn_companyname.Location = new System.Drawing.Point(0, 234);
            this.btn_companyname.Name = "btn_companyname";
            this.btn_companyname.Size = new System.Drawing.Size(218, 43);
            this.btn_companyname.TabIndex = 4;
            this.btn_companyname.Text = "Company Name";
            this.btn_companyname.UseVisualStyleBackColor = true;
            // 
            // btn_patient
            // 
            this.btn_patient.Location = new System.Drawing.Point(0, 176);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(218, 43);
            this.btn_patient.TabIndex = 3;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = true;
            // 
            // btn_doctor
            // 
            this.btn_doctor.Location = new System.Drawing.Point(0, 116);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(218, 43);
            this.btn_doctor.TabIndex = 2;
            this.btn_doctor.Text = "Doctor";
            this.btn_doctor.UseVisualStyleBackColor = true;
            // 
            // btn_vendor
            // 
            this.btn_vendor.Location = new System.Drawing.Point(0, 58);
            this.btn_vendor.Name = "btn_vendor";
            this.btn_vendor.Size = new System.Drawing.Size(218, 43);
            this.btn_vendor.TabIndex = 1;
            this.btn_vendor.Text = "Vendor";
            this.btn_vendor.UseVisualStyleBackColor = true;
            // 
            // btn_medicinestock
            // 
            this.btn_medicinestock.Location = new System.Drawing.Point(0, 0);
            this.btn_medicinestock.Name = "btn_medicinestock";
            this.btn_medicinestock.Size = new System.Drawing.Size(218, 43);
            this.btn_medicinestock.TabIndex = 0;
            this.btn_medicinestock.Text = "Medicine Stock";
            this.btn_medicinestock.UseVisualStyleBackColor = true;
            // 
            // phoneNumberToolStripMenuItem
            // 
            this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
            this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.phoneNumberToolStripMenuItem.Text = "Phone Number";
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
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
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
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Click below to register!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegistrationGridView
            // 
            this.RegistrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrationGridView.Location = new System.Drawing.Point(225, 69);
            this.RegistrationGridView.Name = "RegistrationGridView";
            this.RegistrationGridView.Size = new System.Drawing.Size(1149, 622);
            this.RegistrationGridView.TabIndex = 13;
            // 
            // btn_hospital_registration
            // 
            this.btn_hospital_registration.Location = new System.Drawing.Point(0, 293);
            this.btn_hospital_registration.Name = "btn_hospital_registration";
            this.btn_hospital_registration.Size = new System.Drawing.Size(218, 43);
            this.btn_hospital_registration.TabIndex = 6;
            this.btn_hospital_registration.Text = "Hospital";
            this.btn_hospital_registration.UseVisualStyleBackColor = true;
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(0, 352);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(218, 43);
            this.btn_category.TabIndex = 7;
            this.btn_category.Text = "Medicine Category";
            this.btn_category.UseVisualStyleBackColor = true;
            // 
            // btn_Content_registration
            // 
            this.btn_Content_registration.Location = new System.Drawing.Point(0, 410);
            this.btn_Content_registration.Name = "btn_Content_registration";
            this.btn_Content_registration.Size = new System.Drawing.Size(218, 43);
            this.btn_Content_registration.TabIndex = 8;
            this.btn_Content_registration.Text = "Content";
            this.btn_Content_registration.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.RegistrationGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_companyname;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_vendor;
        private System.Windows.Forms.Button btn_medicinestock;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RegistrationGridView;
        private System.Windows.Forms.Button btn_back_registration;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_hospital_registration;
        private System.Windows.Forms.Button btn_Content_registration;
    }
}