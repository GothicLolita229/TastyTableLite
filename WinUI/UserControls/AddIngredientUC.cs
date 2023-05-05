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

		public Ingredient SelectedIngr()
		{
			Ingredient ing = new Ingredient();
			string name = textBox1.Text;
			double quantity = double.Parse(QuantityComboBox.Text);
			string unit = UnitComboBox.Text;

			ing.Name = name;
			ing.Quantity = quantity;
			ing.Unit = unit;

			return ing;
		}
	}
}
