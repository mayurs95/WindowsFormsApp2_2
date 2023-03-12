using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnLogout_finance_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
