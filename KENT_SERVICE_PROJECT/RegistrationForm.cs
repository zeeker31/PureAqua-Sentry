using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Windows.Forms;

namespace KENT_SERVICE_PROJECT
{
    public partial class RegistrationForm : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=ZAREEN\SQLEXPRESS;Initial Catalog=KENTServiceApp;Integrated Security=True");
        }

        private bool IsEmailValid(string email)
        {
            // Use a regular expression for basic email validation
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }
        private bool IsMobileNumberValid(string mobileNumber)
        {
            // Use a regular expression to validate that the mobile number contains only digits and has a length of 10
            string mobileNumberPattern = @"^\d{10}$";
            return Regex.IsMatch(mobileNumber, mobileNumberPattern);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != string.Empty || txtEnterPassword.Text != string.Empty || txtEnterUsername.Text != string.Empty)
            {
                if (txtEnterPassword.Text == txtConfirmPassword.Text)
                {
                    if (IsEmailValid(txtEnterEmail.Text))
                    {
                        if (IsMobileNumberValid(txtMobileNum.Text))
                        {
                            using (cmd = new SqlCommand("select * from Admin where Username=@Username", conn))
                        
                            cmd.Parameters.AddWithValue("@Username", txtEnterUsername.Text);
                            conn.Open();
                            using (dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    MessageBox.Show("Username Already exists, please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    dr.Close();
                                    cmd = new SqlCommand("INSERT INTO Admin VALUES(@Username, @Password, @Email, @MobileNumber, @Address, @FirstName, @LastName)", conn);
                                    cmd.Parameters.AddWithValue("@Username", txtEnterUsername.Text);
                                    cmd.Parameters.AddWithValue("@Password", txtEnterPassword.Text);
                                    cmd.Parameters.AddWithValue("@Email", txtEnterEmail.Text);
                                    cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNum.Text); // Add the mobile number field
                                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text); // Add the address field
                                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text); // Add the first name field
                                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text); // Add the last name field
                                    cmd.ExecuteNonQuery();
                                    SendRegistrationConfirmationEmail(txtEnterEmail.Text);
                                    MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both passwords the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearAllFields();
        }
        private void ClearAllFields()
        {
            // Clear all text boxes
            txtEnterUsername.Clear();
            txtEnterPassword.Clear();
            txtConfirmPassword.Clear();
            txtEnterEmail.Clear();
            txtMobileNum.Clear();
            txtAddress.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void SendRegistrationConfirmationEmail(string userEmail)
        {
            string senderEmail = "zarru3131@gmail.com"; // Replace with your email address
            string subject = "Registration Confirmation";
            string body = "Thank you for choosing Kent Ro Service for your water purification needs.\n We are delighted to confirm your registration with us.\n  If you have any questions or concerns, feel free to contact our customer service team at zarru3131@gmail.com or 9346320097. \n\n Regards Kent Ro Service App Team.";
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(userEmail);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("zarru3131@gmail.com", "drns nppg pmag yqzg"); // Replace with your email credentials
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
