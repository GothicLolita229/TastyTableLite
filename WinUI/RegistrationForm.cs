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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = userNametxt.Text;
            user.FName = firstNametxt.Text;
            user.LName = lastNametxt.Text;
            user.Salt = User.CreateSalt(10);
            user.HashPass = User.EncryptPassword(passwordtxt.Text, user.Salt);

            SqliteDataAccess.SaveUser(user);

            MessageBox.Show("You have successfully made an account!");
            this.Close();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
