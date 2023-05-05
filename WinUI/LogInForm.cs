using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TastyTableClassLibrary;

namespace WinUI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //checks if user exists via username
            // if i also did password i couldn't verify it properly
            User user = new User();
            //checks if username is null and if it is displays message box
            // if it's filled it, it goes onto the next step of checking the password and etc.
            if (usernametxt.Text == "")
            {
                MessageBox.Show("Please enter in a username in order to log in!");
            }
            else
            {
                string username = usernametxt.Text;
                user = SqliteDataAccess.LoadUser(username);

                // check for password/if user even exists

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password! Try again or register for an account!");
                }
                else
                {
                    string attemptedHashPass = User.EncryptPassword(txtPassword.Text, user.Salt);
                    if (attemptedHashPass == user.HashPass)
                    {
                        MessageBox.Show("You've successfully logged in, welcome!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password! Try again or register for an account!");
                    }
                }
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
