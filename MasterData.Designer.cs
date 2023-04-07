namespace WindowsFormsApp2
{
    partial class MasterData
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_back_allpatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_display_AllPatients = new System.Windows.Forms.Button();
            this.alldoctors = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_display_dgvAllDrugs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_AllDrugs = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.medicineStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediVortexDataSet = new WindowsFormsApp2.MediVortexDataSet();
            this.medicineStockTableAdapter = new WindowsFormsApp2.MediVortexDataSetTableAdapters.MedicineStockTableAdapter();
            this.WholesalerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_display_Wholesalers = new System.Windows.Forms.Button();
            this.DGV_Wholesalers = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.alldoctors.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllDrugs)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediVortexDataSet)).BeginInit();
            this.WholesalerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Wholesalers)).BeginInit();
            this.SuspendLayout();
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
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(851, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 29);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.panel2.Location = new System.Drawing.Point(0, 664);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 32);
            this.panel2.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.alldoctors);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(75, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1374, 635);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1366, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Category";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_back_allpatients);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btn_display_AllPatients);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1366, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "All Patient\'s";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_back_allpatients
            // 
            this.btn_back_allpatients.Location = new System.Drawing.Point(1288, 3);
            this.btn_back_allpatients.Name = "btn_back_allpatients";
            this.btn_back_allpatients.Size = new System.Drawing.Size(75, 23);
            this.btn_back_allpatients.TabIndex = 2;
            this.btn_back_allpatients.Text = "Back";
            this.btn_back_allpatients.UseVisualStyleBackColor = true;
            this.btn_back_allpatients.Click += new System.EventHandler(this.btn_back_allpatients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1363, 619);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_display_AllPatients
            // 
            this.btn_display_AllPatients.Location = new System.Drawing.Point(7, 7);
            this.btn_display_AllPatients.Name = "btn_display_AllPatients";
            this.btn_display_AllPatients.Size = new System.Drawing.Size(75, 23);
            this.btn_display_AllPatients.TabIndex = 0;
            this.btn_display_AllPatients.Text = "Display";
            this.btn_display_AllPatients.UseVisualStyleBackColor = true;
            this.btn_display_AllPatients.Click += new System.EventHandler(this.btn_display_AllPatients_Click);
            // 
            // alldoctors
            // 
            this.alldoctors.Controls.Add(this.panel1);
            this.alldoctors.Location = new System.Drawing.Point(4, 22);
            this.alldoctors.Name = "alldoctors";
            this.alldoctors.Padding = new System.Windows.Forms.Padding(3);
            this.alldoctors.Size = new System.Drawing.Size(1366, 609);
            this.alldoctors.TabIndex = 3;
            this.alldoctors.Text = "All Doctor\'s";
            this.alldoctors.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_display_dgvAllDrugs);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.dataGridView_AllDrugs);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1366, 609);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "All Drug\'s";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_display_dgvAllDrugs
            // 
            this.btn_display_dgvAllDrugs.Location = new System.Drawing.Point(6, 3);
            this.btn_display_dgvAllDrugs.Name = "btn_display_dgvAllDrugs";
            this.btn_display_dgvAllDrugs.Size = new System.Drawing.Size(75, 23);
            this.btn_display_dgvAllDrugs.TabIndex = 2;
            this.btn_display_dgvAllDrugs.Text = "Display";
            this.btn_display_dgvAllDrugs.UseVisualStyleBackColor = true;
            this.btn_display_dgvAllDrugs.Click += new System.EventHandler(this.btn_display_dgvAllDrugs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1288, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_AllDrugs
            // 
            this.dataGridView_AllDrugs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_AllDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllDrugs.Location = new System.Drawing.Point(-4, 29);
            this.dataGridView_AllDrugs.Name = "dataGridView_AllDrugs";
            this.dataGridView_AllDrugs.Size = new System.Drawing.Size(1370, 594);
            this.dataGridView_AllDrugs.TabIndex = 1;
            this.dataGridView_AllDrugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllDrugs_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.WholesalerPanel);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1366, 609);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "All Wholesaler\'s";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btn_back);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1366, 609);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "All Content";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1366, 609);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "All Hospital\'s";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // medicineStockBindingSource
            // 
            this.medicineStockBindingSource.DataMember = "MedicineStock";
            this.medicineStockBindingSource.DataSource = this.mediVortexDataSet;
            // 
            // mediVortexDataSet
            // 
            this.mediVortexDataSet.DataSetName = "MediVortexDataSet";
            this.mediVortexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineStockTableAdapter
            // 
            this.medicineStockTableAdapter.ClearBeforeFill = true;
            // 
            // WholesalerPanel
            // 
            this.WholesalerPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.WholesalerPanel.Controls.Add(this.DGV_Wholesalers);
            this.WholesalerPanel.Controls.Add(this.btn_display_Wholesalers);
            this.WholesalerPanel.Location = new System.Drawing.Point(0, 2);
            this.WholesalerPanel.Name = "WholesalerPanel";
            this.WholesalerPanel.Size = new System.Drawing.Size(1366, 604);
            this.WholesalerPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 604);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 604);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 604);
            this.panel4.TabIndex = 10;
            // 
            // btn_display_Wholesalers
            // 
            this.btn_display_Wholesalers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_display_Wholesalers.Location = new System.Drawing.Point(6, 20);
            this.btn_display_Wholesalers.Name = "btn_display_Wholesalers";
            this.btn_display_Wholesalers.Size = new System.Drawing.Size(75, 23);
            this.btn_display_Wholesalers.TabIndex = 0;
            this.btn_display_Wholesalers.Text = "Display";
            this.btn_display_Wholesalers.UseVisualStyleBackColor = true;
            this.btn_display_Wholesalers.Click += new System.EventHandler(this.btn_display_Wholesalers_Click);
            // 
            // DGV_Wholesalers
            // 
            this.DGV_Wholesalers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Wholesalers.Location = new System.Drawing.Point(0, 50);
            this.DGV_Wholesalers.Name = "DGV_Wholesalers";
            this.DGV_Wholesalers.Size = new System.Drawing.Size(1374, 595);
            this.DGV_Wholesalers.TabIndex = 1;
            // 
            // MasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MasterData";
            this.Text = "MasterData";
            this.Load += new System.EventHandler(this.MasterData_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.alldoctors.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllDrugs)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediVortexDataSet)).EndInit();
            this.WholesalerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Wholesalers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage alldoctors;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_AllDrugs;
        private System.Windows.Forms.Button button1;
        private MediVortexDataSet mediVortexDataSet;
        private System.Windows.Forms.BindingSource medicineStockBindingSource;
        private MediVortexDataSetTableAdapters.MedicineStockTableAdapter medicineStockTableAdapter;
        private System.Windows.Forms.Button btn_display_dgvAllDrugs;
        private System.Windows.Forms.Button btn_back_allpatients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_display_AllPatients;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel WholesalerPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_display_Wholesalers;
        private System.Windows.Forms.DataGridView DGV_Wholesalers;
    }
}