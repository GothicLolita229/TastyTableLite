using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyTableClassLibrary
{
	public class Ingredient
	{
		public Ingredient() { }

		public int IngID { get; set; }
		public string IngName { get; set; }
		public double Quantity { get; set; }
		public string Unit { get; set; }
	}
}
