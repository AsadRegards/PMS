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
using MessageBox = PMS.Toast.MessageBox;

namespace PMS
{
    public partial class Signup : Form
    {
        private readonly UserRepository _userRepository;
        public Signup()
        {
            InitializeComponent();
            _userRepository = UserRepository.Instance;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateSignup(inputFullName.Text, inputPhoneNumber.Text, inputLoginName.Text, inputPassword.Text))
            {
                return;
            }
            var user = new User()
            {
                Name = inputFullName.Text,
                PhoneNumber = inputPhoneNumber.Text,
                LoginName = inputLoginName.Text,
                Password = inputPassword.Text
            };
            if (_userRepository.GetUserByLoginName(user.LoginName) != null) {
                MessageBox.ShowErrorMessage(this,"UserName already exists, Please try another username");
            }
            else
            {
                bool isSuccess = _userRepository.SaveUser(user);
                var Message = isSuccess ? "Signup Succesfull" : "Registration can not be completed at this time, Pleaset try later";
                if (isSuccess) { 
                MessageBox.ShowSuccessMessage(this,Message);
                }
                else
                {
                    MessageBox.ShowErrorMessage(this,Message);
                }
                new Login().Show();
                this.Hide();

            }
        }

        private bool ValidateSignup(string fullName, string phoneNumber, string loginName, string password)
        {
            // Check if full name is empty or null
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.ShowWarningMessage(this,"Full Name is required!!");
                return false; // Stop further processing
            }

            // Check if phone number is empty or null
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.ShowWarningMessage(this,"Phone Number is required!!");
                return false; // Stop further processing
            }

            // Validate phone number format (simple example: should contain only digits and have a length of 10)
            if (!phoneNumber.All(char.IsDigit) || phoneNumber.Length < 11)
            {
                MessageBox.ShowWarningMessage(this,"Please enter valid 11 digits Phone No.");
                return false; // Stop further processing
            }

            // Check if login name is empty or null
            if (string.IsNullOrEmpty(loginName))
            {
                MessageBox.ShowWarningMessage(this,"Login Name is required!!");
                return false; // Stop further processing
            }

            // Check if password is empty or null
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.ShowWarningMessage(this,"Password is required!!");
                return false; // Stop further processing
            }

            return true;
        }


        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
