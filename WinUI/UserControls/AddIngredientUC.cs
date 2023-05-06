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

		public void SelectedIngr()
		{
			Ingredient ing = new Ingredient();
			string name = textBox1.Text;
			double quantity = double.Parse(QuantityComboBox.Text);
			string unit = UnitComboBox.Text;

			ing.Name = name;
			ing.Quantity = quantity;
			ing.Unit = unit;

			SqliteDataAccess.SaveIngredients(ing);
			MessageBox.Show("Saved!"); //Comment out later
			IngredientsForRecipe.Add(ing);
			
		}
	}
}
