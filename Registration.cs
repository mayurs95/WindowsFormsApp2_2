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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set the WindowState property to Maximized

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_registration_Click(object sender, EventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
            string insertQuery = "INSERT INTO MedicineStock (ProductName, ShortName, Company, Packing, Unit, VAT, SGST, CGST, LBT, IGST, ShelfNumber, Category, Type, Department, ShortList, SaleDiscount, BillingMust, SCHH1, NRX, Hold, HSNCode, SchmQty1, SchmQty2, SchmQty3, For1, For2, For3, Content, TherapeuticUse, PurchasedFrom, Doctor, Address, MinimumLevel, MaximumLevel, CalculateRateWithMargin, FixedDiscount, Description) " +
                "VALUES (@ProductName, @ShortName, @Company, @Packing, @Unit, @VAT, @SGST, @CGST, @LBT, @IGST, @ShelfNumber, @Category, @Type, @Department, @ShortList, @SaleDiscount, @BillingMust, @SCHH1, @NRX, @Hold, @HSNCode, @SchmQty1, @SchmQty2, @SchmQty3, @For1, @For2, @For3, @Content, @TherapeuticUse, @PurchasedFrom, @Doctor, @Address, @MinimumLevel, @MaximumLevel, @CalculateRateWithMargin, @FixedDiscount, @Description)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@ProductName", txtproduct.Text);
                command.Parameters.AddWithValue("@ShortName", txtshortname.Text);
                command.Parameters.AddWithValue("@Company", txtcompany.Text);
                command.Parameters.AddWithValue("@Packing", txtpacking.Text);
                command.Parameters.AddWithValue("@Unit", int.Parse(txtunit.Text));
                command.Parameters.AddWithValue("@VAT", decimal.Parse(txtvat.Text));
                command.Parameters.AddWithValue("@SGST", decimal.Parse(txtsgst.Text));
                command.Parameters.AddWithValue("@CGST", decimal.Parse(txtcgst.Text));
                command.Parameters.AddWithValue("@LBT", decimal.Parse(txtlbt.Text));
                command.Parameters.AddWithValue("@IGST", decimal.Parse(txtigst.Text));
                command.Parameters.AddWithValue("@ShelfNumber", txtshelfno.Text);
                command.Parameters.AddWithValue("@Category", txtcategory.Text);
                command.Parameters.AddWithValue("@Type", txttype.Text);
                command.Parameters.AddWithValue("@Department", radiobtnpharma.Checked ? "Pharma" : "General");
                command.Parameters.AddWithValue("@ShortList", radiobtnyes1.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@SaleDiscount", radiobtnyes2.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@BillingMust", radiobtnyes3.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@SCHH1", radiobtnyes4.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@NRX", radiobtnyes5.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@Hold", radiobtnyes6.Checked ? "Yes" : "No");
                command.Parameters.AddWithValue("@HSNCode", texthsncode.Text);
                command.Parameters.AddWithValue("@SchmQty1", int.Parse(txtschmqty1.Text));
                command.Parameters.AddWithValue("@SchmQty2", int.Parse(txtschmqty2.Text));
                command.Parameters.AddWithValue("@SchmQty3", int.Parse(txtschmqty3.Text));
                command.Parameters.AddWithValue("@For1", txtfor1.Text);
                command.Parameters.AddWithValue("@For2", txtfor2.Text);
                command.Parameters.AddWithValue("@For3", txtfor3.Text);
                command.Parameters.AddWithValue("@Content", txtcontent.Text);
                command.Parameters.AddWithValue("@TherapeuticUse", txttheraupticuse.Text);
                command.Parameters.AddWithValue("@PurchasedFrom", txtpurchasedfrom.Text);
                command.Parameters.AddWithValue("@Doctor", txtdoctor.Text);
                command.Parameters.AddWithValue("@Address", txtaddress.Text);
                command.Parameters.AddWithValue("@MinimumLevel", int.Parse(txtminimumlevel.Text));
                command.Parameters.AddWithValue("@MaximumLevel", int.Parse(txtmaximumlevel.Text));
                command.Parameters.AddWithValue("@CalculateRateWithMargin", txtratewithmargin.Text);
                command.Parameters.AddWithValue("@FixedDiscount", decimal.Parse(txtfixeddiscount.Text));
                command.Parameters.AddWithValue("@Description", txtdescription.Text);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtproduct.Text = "";
            txtshortname.Text = "";
            txtcompany.Text = "";
            txtpacking.Text = "";
            txtunit.Text = "";
            txtvat.Text = "";
            txtsgst.Text = "";
            txtcgst.Text = "";
            txtlbt.Text = "";
            txtigst.Text = "";
            txtshelfno.Text = "";
            txtcategory.Text = "";
            txttype.Text = "";
            texthsncode.Text = "";
            txtschmqty1.Text = "";
            txtschmqty2.Text = "";
            txtschmqty3.Text = "";
            txtfor1.Text = "";
            txtfor2.Text = "";
            txtfor3.Text = "";
            txtcontent.Text = "";
            txttheraupticuse.Text = "";
            txtpurchasedfrom.Text = "";
            txtdoctor.Text = "";
            txtaddress.Text = "";
            txtminimumlevel.Text = "";
            txtmaximumlevel.Text = "";
            txtratewithmargin.Text = "";
            txtfixeddiscount.Text = "";
            txtdescription.Text = "";

            // Uncheck all radio buttons
            radiobtnpharma.Checked = false;
            radiobtngeneral.Checked = false;
            radiobtnyes1.Checked = false;
            radiobtnno1.Checked = false;
            radiobtnyes2.Checked = false;
            radiobtnno2.Checked = false;
            radiobtnyes3.Checked = false;
            radiobtnno3.Checked = false;
            radiobtnyes4.Checked = false;
            radiobtnno4.Checked = false;
            radiobtnyes5.Checked = false;
            radiobtnno5.Checked = false;
            radiobtnyes6.Checked = false;
            radiobtnno6.Checked = false;
        }

        private void btn_Back_patient_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to the SQL Server database
                string connectionString = @"Data Source=DESKTOP-R9V99R0;Initial Catalog=MediVortex;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SQL INSERT statement
                    string insertQuery = "INSERT INTO Patients (PatientName, BirthDate, Address, ContactNumber, EmailAddress, Allergies, Doctor) VALUES (@PatientName, @BirthDate, @Address, @ContactNumber, @EmailAddress, @Allergies, @Doctor)";

                    // Set the parameter values of the SQL INSERT statement
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientName", txtpatientname.Text);
                        command.Parameters.AddWithValue("@BirthDate", dtp_birthdate.Value);
                        command.Parameters.AddWithValue("@Address", txt_address.Text);
                        command.Parameters.AddWithValue("@ContactNumber", txtcontactnumber.Text);
                        command.Parameters.AddWithValue("@EmailAddress", txtemailaddress.Text);
                        command.Parameters.AddWithValue("@Allergies", txtallergies.Text);
                        command.Parameters.AddWithValue("@Doctor", txt_doctor.Text);

                        // Execute the SQL INSERT statement
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient record saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Unable to save patient record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving patient record: " + ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtpatientname.Text = "";
            dtp_birthdate.Value = dtp_birthdate.MinDate;
            txt_address.Text = "";
            txtcontactnumber.Text = "";
            txtemailaddress.Text = "";
            txtallergies.Text = "";
            txt_doctor.Text = "";

        }
    }
}
