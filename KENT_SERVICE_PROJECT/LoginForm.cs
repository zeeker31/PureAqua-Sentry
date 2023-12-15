using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KENT_SERVICE_PROJECT
{
    public partial class LoginForm : Form
    {
        private SqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=ZAREEN\SQLEXPRESS;Initial Catalog=KENTServiceApp;Integrated Security=True");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string user_password = txtpassword.Text;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Admin WHERE Username = @Username AND Password = @Password";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@Username", username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", user_password);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MainForm form2 = new MainForm();
                    form2.Username = username; // Pass the username to the MainForm
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }

        private void btnForgotPwd_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }
    }
}
