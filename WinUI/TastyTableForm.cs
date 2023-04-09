using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
	public partial class TastyTableForm : Form
	{
		public TastyTableForm()
		{
			InitializeComponent();
		}

		private void TastyTableForm_Load(object sender, EventArgs e)
		{
			// Hide All User Controls except the home page
			// TODO Maybe make this the login page, either that or have an overlay login
			recipeBookUCF.Hide();
			addRecipeUCF.Hide();
			aboutUCF.Hide();
			searchUCF.Hide();
		}

		private void HomeButton_Click(object sender, EventArgs e)
		{
			// Hide All User Controls except the home page
			recipeBookUCF.Hide();
			addRecipeUCF.Hide();
			aboutUCF.Hide();
			searchUCF.Hide();
			// Bring Home page back to front
			homeUCF.Show();
			homeUCF.BringToFront();
		}

		private void RecipeBookButton_Click(object sender, EventArgs e)
		{
			// Hide All User Controls except the Recipe Book page
			homeUCF.Hide();
			addRecipeUCF.Hide();
			aboutUCF.Hide();
			searchUCF.Hide();
			// Bring Recipe Book page back to front
			recipeBookUCF.Show();
			recipeBookUCF.BringToFront();
		}

		private void AddRecipeButton_Click(object sender, EventArgs e)
		{
			// Hide All User Controls except the Add Recipe page
			homeUCF.Hide();
			recipeBookUCF.Hide();
			aboutUCF.Hide();
			searchUCF.Hide();
			// Bring Add Recipe page back to front
			addRecipeUCF.Show();
			addRecipeUCF.BringToFront();
		}

		private void AboutButton_Click(object sender, EventArgs e)
		{
			// Hide All User Controls except the About page
			homeUCF.Hide();
			recipeBookUCF.Hide();
			addRecipeUCF.Hide();
			searchUCF.Hide();
			// Bring About page back to front
			aboutUCF.Show();
			aboutUCF.BringToFront();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			// Hide All User Controls except the Search page
			homeUCF.Hide();
			recipeBookUCF.Hide();
			addRecipeUCF.Hide();
			aboutUCF.Hide();
			// Bring Search page back to front
			searchUCF.Show();
			searchUCF.BringToFront();
		}
	}
}
