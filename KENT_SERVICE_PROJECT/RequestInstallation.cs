using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KENT_SERVICE_PROJECT
{
    public partial class RequestInstallation : Form
    {
        private string connectionString = "Data Source=ZAREEN\\SQLEXPRESS;Initial Catalog=KENTServiceApp;Integrated Security=True";

        public RequestInstallation()
        {
            InitializeComponent();
            LoadProductsIntoComboBox();
        }

        private void LoadProductsIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT product_name FROM Product";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        
                        cmbProduct.DisplayMember = "product_name"; 
                        cmbProduct.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbProduct.SelectedItem != null)
            {
               
                string selectedProductName = cmbProduct.SelectedItem.ToString();

                
                string serialNumber = GetSerialNumberForProduct(selectedProductName);

                
                txtSerialNum.Text = serialNumber;
            }
        }

        private string GetSerialNumberForProduct(string productName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT serial_number FROM Product WHERE product_name = @ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@ProductName", productName);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching serial number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return string.Empty;
        }
    }
}

