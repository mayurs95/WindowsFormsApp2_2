using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set the WindowState property to Maximized

        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form.
            this.Close();

            // Create and show a new instance of the LoginForm class.
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the current form.
            this.Close();

            // Create and show a new instance of the Inventory class.        
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_transaction_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();

            Transactions transactions = new Transactions();
            transactions.Show();
        }

        private void btn_masterdata_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            MasterData masterData = new MasterData();
            masterData.Show();
        }

        private void btn_reports_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports reports = new Reports();
            reports.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

            Finance finance = new Finance();
            finance.Show();
        }
    }
}
