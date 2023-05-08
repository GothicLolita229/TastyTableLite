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
				DisplayTextBox.Text += item.Quantity + " " + item.Unit + " " + item.IngName + " ";
			}

			// Searches based on ID
			foreach (int ingID in ingIDs)
			{
				recBrid.Add(SqliteDataAccess.LoadRecFromBridge(ingID));
			}
			// Makes a unique list of all recipes without duplicates
			List<int> uniqueRecBrid = recBrid.Distinct().ToList();

			// Pull the Recipe name, temp, and C or F based on uniqueRecBrid

			// Pull ingredients and intructions and attach them to each recipe

			// Display them
		}
	}
}
