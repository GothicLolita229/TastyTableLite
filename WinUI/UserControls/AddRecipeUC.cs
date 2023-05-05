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
using Button = System.Windows.Forms.Button;

namespace WinUI
{
	public partial class AddRecipeUC : UserControl
	{
		public List<Ingredient> IngredientsForRecipe = new List<Ingredient>();
		public AddRecipeUC()
		{
			InitializeComponent();
		}

		int addIngrControl = 5;
		int addIngButton = 5;
		private void AddIngButton_Click(object sender, EventArgs e)
		{
			AddIngredientUC newIng = new AddIngredientUC();
			Button newButton = new Button();
			this.Controls.Add(newIng);
			this.Controls.Add(newButton);

			newIng.Top = addIngrControl * 40;
			newButton.Top = addIngButton * 40;
			newIng.Left = 11;
			newButton.Left = 500;
			addIngButton += 1;
			addIngrControl += 1;
		}

		
	}
}
