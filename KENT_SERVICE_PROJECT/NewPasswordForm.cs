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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KENT_SERVICE_PROJECT
{
    public partial class NewPasswordForm : Form
    {
        private string formUsername;
        private string formEmail;

        public NewPasswordForm(string username, string email)
        {
            InitializeComponent();
            this.formUsername = username;
            this.formEmail = email;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword == confirmPassword)
            {
                // Update the password in the database
                UpdatePasswordInDatabase(newPassword);

                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Proceed to the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePasswordInDatabase(string newPassword)
        {
            // Connect to the database
            using (SqlConnection connection = new SqlConnection("Data Source=ZAREEN\\SQLEXPRESS;Initial Catalog=KENTServiceApp;Integrated Security=True"))
            {
                connection.Open();

                // Create and execute the SQL command
                using (SqlCommand command = new SqlCommand("UPDATE Admin SET Password = @newPassword WHERE Username = @username", connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@username", formUsername);
           

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

