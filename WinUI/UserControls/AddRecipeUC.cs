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
		
		public AddRecipeUC()
		{
			InitializeComponent();
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

		
	}
}
