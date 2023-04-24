using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyTableClassLibrary
{
	public class Recipe
	{
		public Recipe() { }

		public int ID { get; set; }
		public string Name { get; set; }
		public int TempNum { get; set; }
		public string TempChar { get; set; }
	}
}
