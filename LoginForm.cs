using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //niche wala se login button ka color change function activate hota he
            btn_login.MouseEnter += btn_login_Enter;
            btn_login.MouseLeave += btn_login_Leave;
            this.DoubleBuffered = true; // set the DoubleBuffered property to true
            this.WindowState = FormWindowState.Maximized; // set the WindowState property to Maximized

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }


        //below is login method so we can use login code multiple time in short cut
        private void Login()
        {
            // Retrieve the values entered by the user in the textboxes.
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Create a connection object using the connection string.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";

            try
            {
                // Open the connection.
                connection.Open();

                // Create a SqlCommand object to retrieve the user credentials from the Users table.
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", connection);

                // Add parameters to the SqlCommand object to avoid SQL injection attacks.
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                // Execute the query and retrieve the result.
                int count = (int)command.ExecuteScalar();

                // Check if the user credentials were found in the database.
                if (count > 0)
                {
                    //MessageBox.Show("Login successful!");
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please check your username and password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection.
                connection.Close();
            }
        }

        //using below code we can decide konse button se kya hoga
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        // using below code hum textbox ke andar likh sakte jo user click karega tho gayab hoga
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Enter Login Id";
            txtUsername.ForeColor = Color.Gray;

            txtPassword.Text = "Enter Password";
            txtPassword.ForeColor = Color.Gray;
           

        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Login Id")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Enter Login Id";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //curser textbox me jayega nahi directly
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

        }

        private void btn_login_Enter(object sender, EventArgs e)
        {
            //btn_login.BackColor = Color.Blue;
            //btn_login.ForeColor = Color.Pink;
            //btn_login.FlatAppearance.BorderColor = Color.Pink;
            btn_login.BackColor = Color.FromArgb(36, 129, 77);
            btn_login.ForeColor = Color.White;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(36, 129, 77);
        }

        private void btn_login_Leave(object sender, EventArgs e)
        {
            //btn_login.BackColor = DefaultBackColor;
            //btn_login.ForeColor = DefaultForeColor;
            //btn_login.FlatAppearance.BorderColor = DefaultBackColor;
            //btn_login.BackColor = Color.White;
            //btn_login.ForeColor = Color.Black;
            //btn_login.FlatAppearance.BorderColor = Color.Black;
            btn_login.BackColor = Color.SteelBlue;
            btn_login.ForeColor = Color.White;
            btn_login.FlatAppearance.BorderColor = Color.White;
        }

       
    }

}
