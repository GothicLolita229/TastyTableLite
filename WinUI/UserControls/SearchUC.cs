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
using System.Linq;
using System.Net.NetworkInformation;

namespace WinUI
{
	public partial class SearchUC : UserControl
	{
		public SearchUC()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			// Search from database using text
			// Clears Display
			DisplayTextBox.Text = "";
			// List to pull ingredients that match the search
			List<Ingredient> ingSearch;

			// List to store the ingredient IDs so we can search bridging table
			List<int> ingIDs = new List<int>();

			// List to store the recipe IDs we got from the bridging table
			List<int> recBrid = new List<int>();
			
			// the var to store the search term
			string search = SearchTextBox.Text;

			// pulls from database to fill list of ingredients that match the search
			ingSearch = SqliteDataAccess.LoadIngredients(search);

			//loops through the above list and adds the IDs to a list that we will use for searching
			foreach (Ingredient item in ingSearch)
			{
				ingIDs.Add(item.IngID);
			}

			// Searches based on ID
			foreach (int ingID in ingIDs)
			{
				recBrid.Add(SqliteDataAccess.LoadRecFromBridge(ingID));
			}
			// Makes a unique list of all recipes without duplicates
			List<int> uniqueRecBrid = recBrid.Distinct().ToList();

			// Pull the Recipe name, temp, and C or F based on uniqueRecBrid

			foreach (int recID in uniqueRecBrid)
			{
				// Creates a list of object for each recipe pulled
				Recipe recipe = SqliteDataAccess.LoadRecipeOnID(recID);
				// Displays Recipe name for each recipe
				DisplayTextBox.Text += " \r\n\r\n" + recipe.RecName + " \r\n" + string.Format("{0}\u00B0", recipe.TempNum) + recipe.TempChar + " \r\n";
				// Goes to bridging table to get the ID of each ingredient that matches the recipe and stores it to list
				List<int> ingsIDs = SqliteDataAccess.LoadIngFromBridge(recID);
				// loops through ID list and pulls each ingredient as object to display
				List<Ingredient> ings = new List<Ingredient>();
				foreach(int ingID in ingsIDs)
				{
					ings.Add(SqliteDataAccess.LoadIngredientID(ingID));
				}
				// Displays ingredients
				foreach (Ingredient ing in ings)
				{
					DisplayTextBox.Text += ing.Quantity + " " + ing.Unit + " " + ing.IngName + " \r\n";
				}
				List<Instruction> insts = SqliteDataAccess.LoadInstructions(recID);
				DisplayTextBox.Text += " \r\n" + "Directions" + " \r\n\r\n";
				foreach (Instruction inst in insts)
				{
					DisplayTextBox.Text += " \r\n" + inst.StepNum + " " + inst.Description + " \r\n";
				}
			}
			
		}
	}
}
