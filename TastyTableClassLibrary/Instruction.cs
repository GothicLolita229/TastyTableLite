using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyTableClassLibrary
{
	public class Instruction
	{
		public Instruction() { }

		public int ID { get; set; } //An autoincremented unique identifier
		public int StepNum { get; set; } //Each step is numbered like 1, 2, 3
		public string Description { get; set; }
	}
}
