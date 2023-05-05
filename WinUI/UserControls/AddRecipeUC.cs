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
using WinUI.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinUI
{
	public partial class AddRecipeUC : UserControl
	{
		public AddRecipeUC()
		{
			InitializeComponent();
		}

		int addIngrControl = 1;
		private void AddIngButton_Click(object sender, EventArgs e)
		{
			AddIngredientUC newIng = new AddIngredientUC();
			this.Controls.Add(newIng);

			newIng.Top = addIngrControl * 50;
			newIng.Left = 11;
			addIngrControl += 1;

			//User user = new User();
			
			//user.Username = userNametxt.Text;
			//user.FName = firstNametxt.Text;
			//user.LName = lastNametxt.Text;
			//user.Salt = User.CreateSalt(10);
			//user.HashPass = User.EncryptPassword(passwordtxt.Text, user.Salt);

			//SqliteDataAccess.SaveUser(user);

			//MessageBox.Show("You have successfully made an account!");
			//this.Close();
			
			

			
		}

		
	}
}
