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

namespace WindowsFormsApp2
{
    public partial class MasterData : Form
    {
        public MasterData()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set the WindowState property to Maximized

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MasterData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediVortexDataSet.MedicineStock' table. You can move, or remove it, as needed.
            this.medicineStockTableAdapter.Fill(this.mediVortexDataSet.MedicineStock);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicineStockTableAdapter.FillBy(this.mediVortexDataSet.MedicineStock);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_AllDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Query the MedicineStock table to retrieve the medicine data
            string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
            string query = "SELECT * FROM MedicineStock";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Populate the DataGridView control with the medicine data
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView_AllDrugs.DataSource = dataTable;

                    reader.Close();
                }
            }
        }

        private void btn_display_dgvAllDrugs_Click(object sender, EventArgs e)
        {
            // Query the MedicineStock table to retrieve the medicine data
            string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
            string query = "SELECT * FROM MedicineStock";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Populate the DataGridView control with the medicine data
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView_AllDrugs.DataSource = dataTable;

                    reader.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create a connection to the SQL Server database
            string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SQL SELECT statement to retrieve all patients from the Patients table
                string selectQuery = "SELECT * FROM Patients";

                // Create a SqlCommand object to execute the SELECT statement and retrieve the results
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Create a SqlDataAdapter object to populate a DataTable with the results of the SELECT statement
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a new DataTable object to hold the results of the SELECT statement
                        DataTable patientsTable = new DataTable();

                        // Use the SqlDataAdapter to fill the DataTable with the results of the SELECT statement
                        adapter.Fill(patientsTable);

                        // Bind the DataTable to the DataSource property of the DataGridView
                        dataGridView1.DataSource = patientsTable;
                    }
                }
            }
        }

        private void btn_display_AllPatients_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to the SQL Server database
                string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SQL SELECT statement to retrieve all patient records
                    string selectQuery = "SELECT * FROM Patients";

                    // Create a SqlDataAdapter to execute the SQL SELECT statement and fill a DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Bind the DataTable to the DataGridView to display the data
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patient records: " + ex.Message);
            }
        }

        private void btn_back_allpatients_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
    
}
