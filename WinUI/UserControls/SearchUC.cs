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
	public partial class SearchUC : UserControl
	{
		public SearchUC()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			//Search from database using text
			DisplayTextBox.Text = string.Empty;
		}
	}
}
