using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee
{
	public class Duo
		: nilnul.Duo<double>
	{
		public Duo(double item1, double item2) : base(item1, item2)
		{
		}

		public double shift {
			get {
				return Item2 - Item1;
			}
		}
	}
}
