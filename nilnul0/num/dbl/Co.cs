using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl
{
	public class Co
		: nilnul.obj.Duo<double>
	{
		public Co(double item1, double item2) : base(item1, item2)
		{
		}

		public double shift {
			get {
				return Item2 - Item1;
			}
		}
	}
}
