﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TastyTableClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinUI.UserControls
{
	public partial class AddIngredientUC : UserControl
	{
		public AddIngredientUC()
		{
			InitializeComponent();
		}
		public List<Ingredient> IngredientsForRecipe = new List<Ingredient>();
		//public RecipeBridge recipeBridge = new RecipeBridge();
		public int recipeID;
		public int ingredientID;

        public void SelectedIngr()
		{
			Ingredient ing = new Ingredient();
			string name = textBox1.Text;
			double quantity = double.Parse(QuantityComboBox.Text);
			string unit = UnitComboBox.Text;

			RecipeBridge recipeBridge = new RecipeBridge();

			ing.IngName = name;
			ing.Quantity = quantity;
			ing.Unit = unit;

			//SqliteDataAccess.SaveIngredients(ing);
			ingredientID = SqliteDataAccess.SaveIngrReturnID(ing);
			MessageBox.Show("Saved!"); //Comment out later
			IngredientsForRecipe.Add(ing);
			recipeID = AddRecipeUC.PassRecipeID();
			//ingredientID = SqliteDataAccess.LoadIngredientID(ing.Name).ID;
			//MessageBox.Show(recipeID.ToString() + ingredientID.ToString());
			recipeBridge.RecID = recipeID;
			recipeBridge.IngID = ingredientID;
			SqliteDataAccess.SavetoBridge(recipeBridge);
			// Fix recipeID retrieval 
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			SelectedIngr();
            
        }

	}
}
