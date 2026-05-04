using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FILLONE_OOP_CPE201
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username, password;
            password = "iloveasher";
            username = "a.jnin";
            if (usernameTXTBOX.Text == username && passwordTXTBX.Text == password)
            {
                MessageBox.Show("Welcome" + username + "!!");
                MainForm adminfrm = new MainForm();
                adminfrm.Show();
                this.Hide();
            }
            else if (usernameTXTBOX.Text == "cashier" && passwordTXTBX.Text == "12345")
            {
                MessageBox.Show("Welcome Cashier!!");
                Activity2New cashierfrm = new Activity2New();
                cashierfrm.Show();
                usernameTXTBOX.Clear();
                passwordTXTBX.Clear();
            }
            else 
            { 
                MessageBox.Show("Invalid username or password!!");
                usernameTXTBOX.Clear();
                passwordTXTBX.Clear();
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
