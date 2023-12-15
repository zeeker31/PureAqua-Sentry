using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KENT_SERVICE_PROJECT
{
    public partial class MainForm : Form
    {
        private string _username;

        public MainForm()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                UpdateWelcomeMessage();
            }
        }

        private void UpdateWelcomeMessage()
        {
            lblText.Text = $"Hi {_username}!";
            lblWelcome.Text = $"Welcome to Kent Service App";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestInstallation requestForm = new RequestInstallation();
            requestForm.Show();
           
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            RequestService requestService = new RequestService();
            requestService.Show();
            
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            MyProducts Products = new MyProducts();
            Products.Show();
           
        }

        private void btnServiceHistory_Click(object sender, EventArgs e)
        {
            ServiceHistory history = new ServiceHistory();
            history.Show();
            
        }
    }
}



