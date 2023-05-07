using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TastyTableClassLibrary;
using WinUI.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WinUI
{
	public partial class AddRecipeUC : UserControl
	{
		public static Recipe newRecipe = new Recipe();
		public AddRecipeUC()
		{
			InitializeComponent();
			QuantityLabel.Visible= false;
			UnitLabel.Visible= false;
			IngNameLabel.Visible = false;
			AddIngButton.Visible = false;
			TempCharComboBox.Visible = false;
			TempCharLabel.Visible = false;
			RecipeNameLabel.Visible = false;
			RecipeNameTextBox.Visible = false;
			TempNumLabel.Visible = false;
			TempNumTextBox.Visible = false;
			DisplayRecipeTextBox.Visible = false;
			ReadyButton.Visible = false;
		}

		int addIngrControl = 5;
		private void AddIngButton_Click(object sender, EventArgs e)
		{
			AddIngredientUC newIng = new AddIngredientUC();
			this.Controls.Add(newIng);

			newIng.Top = addIngrControl * 40;
			newIng.Left = 11;
			addIngrControl += 1;
		}

		private void AddNewRecipeButton_Click(object sender, EventArgs e)
		{
			//QuantityLabel.Visible = true;
			//UnitLabel.Visible = true;
			//IngNameLabel.Visible = true;
			//AddIngButton.Visible = true;
			TempCharComboBox.Visible = true;
			TempCharLabel.Visible = true;
			RecipeNameLabel.Visible = true;
			RecipeNameTextBox.Visible = true;
			TempNumLabel.Visible = true;
			TempNumTextBox.Visible = true;
			ReadyButton.Visible = true;

		}

		public void SaveRecipeName()
		{
			DisplayRecipeTextBox.Visible = true;
			newRecipe.Name = RecipeNameTextBox.Text;
			Int32.TryParse(TempNumTextBox.Text, out int temp);
			newRecipe.TempNum = temp;
			newRecipe.TempChar = TempCharComboBox.Text;
			SqliteDataAccess.SaveRecipe(newRecipe);
		}

		private void ReadyButton_Click(object sender, EventArgs e)
		{
			QuantityLabel.Visible = true;
			UnitLabel.Visible = true;
			IngNameLabel.Visible = true;
			AddIngButton.Visible = true;
			SaveRecipeName();
			string name = newRecipe.Name;

			List<Recipe> recDisplay = SqliteDataAccess.LoadRecipe();
			int id = SqliteDataAccess.LoadRecipeID(name).ID;
			DisplayRecipeTextBox.Text = id.ToString();


			//foreach (Recipe rec in recDisplay) { DisplayRecipeTextBox.Text = rec.Name; }
		}

        //public int GetRecipeID()
        //{
			//return newRecipe.ID;
        //}

		internal static int PassRecipeID()
		{
            return newRecipe.ID;
        }
	}
}
