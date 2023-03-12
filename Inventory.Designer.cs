namespace WindowsFormsApp2
{
    partial class Inventory 
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
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Companydropdown = new System.Windows.Forms.ComboBox();
            this.Drugdropdown = new System.Windows.Forms.ComboBox();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(0, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 39);
            this.panel2.TabIndex = 11;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(135, 70);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 32);
            this.button12.TabIndex = 10;
            this.button12.Text = "Search :";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 32);
            this.textBox1.TabIndex = 9;
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
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 429);
            this.panel1.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 293);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 43);
            this.button7.TabIndex = 5;
            this.button7.Text = "All Drug Contain";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 43);
            this.button6.TabIndex = 4;
            this.button6.Text = "All Drugs Available";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "Inventory by company";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "Near to expire";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Shortage of stock";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Available Stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // phoneNumberToolStripMenuItem
            // 
            this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
            this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.emailAddressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // Companydropdown
            // 
            this.Companydropdown.DropDownHeight = 200;
            this.Companydropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Companydropdown.FormattingEnabled = true;
            this.Companydropdown.IntegralHeight = false;
            this.Companydropdown.ItemHeight = 13;
            this.Companydropdown.Items.AddRange(new object[] {
            "Sun Pharmaceutical Industries Ltd.",
            "Divis Laboratories Ltd.",
            "Dr. Reddys Laboratories Ltd.",
            "Cipla Ltd.",
            "Apollo Hospitals Enterprise Ltd.",
            "Torrent Pharmaceuticals Ltd. ",
            "Zydus Lifesciences Ltd.",
            "Abbott India Ltd."});
            this.Companydropdown.Location = new System.Drawing.Point(612, 81);
            this.Companydropdown.Name = "Companydropdown";
            this.Companydropdown.Size = new System.Drawing.Size(236, 21);
            this.Companydropdown.TabIndex = 12;
            this.Companydropdown.Text = "Company ";
            // 
            // Drugdropdown
            // 
            this.Drugdropdown.DropDownHeight = 200;
            this.Drugdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drugdropdown.FormattingEnabled = true;
            this.Drugdropdown.IntegralHeight = false;
            this.Drugdropdown.ItemHeight = 13;
            this.Drugdropdown.Items.AddRange(new object[] {
            "lisinopril (Zestril)",
            "levothyroxine (Synthroid)",
            "atorvastatin (Lipitor)",
            "metformin (Glucophage)",
            "simvastatin (Zocor)",
            "omeprazole (Prilosec)",
            "amlodipine (Norvasc)",
            "metoprolol (Lopressor)"});
            this.Drugdropdown.Location = new System.Drawing.Point(886, 81);
            this.Drugdropdown.Name = "Drugdropdown";
            this.Drugdropdown.Size = new System.Drawing.Size(236, 21);
            this.Drugdropdown.TabIndex = 13;
            this.Drugdropdown.Text = "Drug";
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InventoryGridView.Location = new System.Drawing.Point(224, 146);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.Size = new System.Drawing.Size(1134, 518);
            this.InventoryGridView.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(0, 354);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(218, 43);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back <";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 710);
            this.Controls.Add(this.InventoryGridView);
            this.Controls.Add(this.Drugdropdown);
            this.Controls.Add(this.Companydropdown);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox Companydropdown;
        private System.Windows.Forms.ComboBox Drugdropdown;
        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.Button btn_back;
    }
}