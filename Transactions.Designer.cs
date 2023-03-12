namespace WindowsFormsApp2
{
    partial class Transactions
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dailysales_transaction = new System.Windows.Forms.Button();
            this.btn_purchasereturn_transaction = new System.Windows.Forms.Button();
            this.btn_salesreturn_transaction = new System.Windows.Forms.Button();
            this.btn_cheque_paid_transaction = new System.Windows.Forms.Button();
            this.btn_cheque_recieved_transaction = new System.Windows.Forms.Button();
            this.btn_cashpaid_transaction = new System.Windows.Forms.Button();
            this.btn_Cash_recipt_transaction = new System.Windows.Forms.Button();
            this.btn_Purchase_entry_transactions = new System.Windows.Forms.Button();
            this.btn_sales_entry_transactions = new System.Windows.Forms.Button();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 32);
            this.panel2.TabIndex = 11;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(0, 525);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(218, 43);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_dailysales_transaction);
            this.panel1.Controls.Add(this.btn_purchasereturn_transaction);
            this.panel1.Controls.Add(this.btn_salesreturn_transaction);
            this.panel1.Controls.Add(this.btn_cheque_paid_transaction);
            this.panel1.Controls.Add(this.btn_cheque_recieved_transaction);
            this.panel1.Controls.Add(this.btn_cashpaid_transaction);
            this.panel1.Controls.Add(this.btn_Cash_recipt_transaction);
            this.panel1.Controls.Add(this.btn_Purchase_entry_transactions);
            this.panel1.Controls.Add(this.btn_sales_entry_transactions);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 581);
            this.panel1.TabIndex = 8;
            // 
            // btn_dailysales_transaction
            // 
            this.btn_dailysales_transaction.Location = new System.Drawing.Point(0, 467);
            this.btn_dailysales_transaction.Name = "btn_dailysales_transaction";
            this.btn_dailysales_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_dailysales_transaction.TabIndex = 8;
            this.btn_dailysales_transaction.Text = "Daily Sales";
            this.btn_dailysales_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_purchasereturn_transaction
            // 
            this.btn_purchasereturn_transaction.Location = new System.Drawing.Point(0, 409);
            this.btn_purchasereturn_transaction.Name = "btn_purchasereturn_transaction";
            this.btn_purchasereturn_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_purchasereturn_transaction.TabIndex = 7;
            this.btn_purchasereturn_transaction.Text = "Purchase Return";
            this.btn_purchasereturn_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_salesreturn_transaction
            // 
            this.btn_salesreturn_transaction.Location = new System.Drawing.Point(0, 351);
            this.btn_salesreturn_transaction.Name = "btn_salesreturn_transaction";
            this.btn_salesreturn_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_salesreturn_transaction.TabIndex = 6;
            this.btn_salesreturn_transaction.Text = "Sales Return";
            this.btn_salesreturn_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_cheque_paid_transaction
            // 
            this.btn_cheque_paid_transaction.Location = new System.Drawing.Point(0, 293);
            this.btn_cheque_paid_transaction.Name = "btn_cheque_paid_transaction";
            this.btn_cheque_paid_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_cheque_paid_transaction.TabIndex = 5;
            this.btn_cheque_paid_transaction.Text = "Cheque Paid";
            this.btn_cheque_paid_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_cheque_recieved_transaction
            // 
            this.btn_cheque_recieved_transaction.Location = new System.Drawing.Point(0, 234);
            this.btn_cheque_recieved_transaction.Name = "btn_cheque_recieved_transaction";
            this.btn_cheque_recieved_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_cheque_recieved_transaction.TabIndex = 4;
            this.btn_cheque_recieved_transaction.Text = "Cheque Recieved";
            this.btn_cheque_recieved_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_cashpaid_transaction
            // 
            this.btn_cashpaid_transaction.Location = new System.Drawing.Point(0, 176);
            this.btn_cashpaid_transaction.Name = "btn_cashpaid_transaction";
            this.btn_cashpaid_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_cashpaid_transaction.TabIndex = 3;
            this.btn_cashpaid_transaction.Text = "Cash Paid";
            this.btn_cashpaid_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_Cash_recipt_transaction
            // 
            this.btn_Cash_recipt_transaction.Location = new System.Drawing.Point(0, 116);
            this.btn_Cash_recipt_transaction.Name = "btn_Cash_recipt_transaction";
            this.btn_Cash_recipt_transaction.Size = new System.Drawing.Size(218, 43);
            this.btn_Cash_recipt_transaction.TabIndex = 2;
            this.btn_Cash_recipt_transaction.Text = "Cash Recipt";
            this.btn_Cash_recipt_transaction.UseVisualStyleBackColor = true;
            // 
            // btn_Purchase_entry_transactions
            // 
            this.btn_Purchase_entry_transactions.Location = new System.Drawing.Point(0, 58);
            this.btn_Purchase_entry_transactions.Name = "btn_Purchase_entry_transactions";
            this.btn_Purchase_entry_transactions.Size = new System.Drawing.Size(218, 43);
            this.btn_Purchase_entry_transactions.TabIndex = 1;
            this.btn_Purchase_entry_transactions.Text = "Purchase Entry";
            this.btn_Purchase_entry_transactions.UseVisualStyleBackColor = true;
            // 
            // btn_sales_entry_transactions
            // 
            this.btn_sales_entry_transactions.Location = new System.Drawing.Point(0, 0);
            this.btn_sales_entry_transactions.Name = "btn_sales_entry_transactions";
            this.btn_sales_entry_transactions.Size = new System.Drawing.Size(218, 43);
            this.btn_sales_entry_transactions.TabIndex = 0;
            this.btn_sales_entry_transactions.Text = "Sales Entry";
            this.btn_sales_entry_transactions.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1133, 581);
            this.dataGridView1.TabIndex = 12;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dailysales_transaction;
        private System.Windows.Forms.Button btn_purchasereturn_transaction;
        private System.Windows.Forms.Button btn_salesreturn_transaction;
        private System.Windows.Forms.Button btn_cheque_paid_transaction;
        private System.Windows.Forms.Button btn_cheque_recieved_transaction;
        private System.Windows.Forms.Button btn_cashpaid_transaction;
        private System.Windows.Forms.Button btn_Cash_recipt_transaction;
        private System.Windows.Forms.Button btn_Purchase_entry_transactions;
        private System.Windows.Forms.Button btn_sales_entry_transactions;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}