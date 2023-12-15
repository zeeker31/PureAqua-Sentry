using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace KENT_SERVICE_PROJECT
{
    public partial class ForgotPasswordForm : Form
    {
        private string connectionString = "Data Source=ZAREEN\\SQLEXPRESS;Initial Catalog=KENTServiceApp;Integrated Security=True"; // Replace with your actual connection string

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text.Trim();

            string password = GetPasswordFromDatabase(email);

            if (!string.IsNullOrEmpty(password))
            {
                SendGeneratedPasswordEmail(email, password);
                MessageBox.Show("Password sent to the entered email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to retrieve the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendGeneratedPasswordEmail(string email, string generatedPassword)
        {
            string senderEmail = "zarru3131@gmail.com";

            // Get the username from the database
            string username = GetUsernameFromDatabase(email);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Unable to retrieve username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(email); // Use the entered email
            mailMessage.Subject = "Your New Password";
            mailMessage.Body = $"Hello {username}!\n\nYour new password is: {generatedPassword}";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("zarru3131@gmail.com", "drns nppg pmag yqzg");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);

                NewPasswordForm newPasswordForm = new NewPasswordForm(username, email);
                newPasswordForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUsernameFromDatabase(string userEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT Username FROM Admin WHERE Email = '{userEmail}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }
        private string GetPasswordFromDatabase(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Update the query to retrieve password based on email
                string query = $"SELECT Password FROM Admin WHERE Email = '{email}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }

                
            }
        } } }







