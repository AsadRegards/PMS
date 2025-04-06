using PMS.PMS.Data.Repositories;
using PMS.PMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Login : Form
    {
        private UserRepository _userRepository;
        public Login()
        {
            _userRepository = UserRepository.Instance;
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!validateLoginNameandPassword(this.inputLoginName.Text, this.inputPasword.Text))
            {
                return;
            }
            User user = _userRepository.GetUserByLoginName(this.inputLoginName.Text);
            if (user == null)
            {
                MessageBox.Show("User Not Found!");
            }
            else
            {
                if (user.Password != this.inputPasword.Text)
                {
                    MessageBox.Show("Invalid Password!!");
                }
                else
                {
                    _userRepository.CurrentUser = user;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
        }

        private bool validateLoginNameandPassword(string userName, string Password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Please Enter Valid LoginName");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please Enter Valid Password");
                return false;
            }
            return true;
        }

        private void SignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
