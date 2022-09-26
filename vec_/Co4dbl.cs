using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		co
	///			as in: nino, uno, co tro, quod,quino
	///		duo
	///			as in nio, uno, duo, tro, quo,
	public class Co4dbl
		:
		nilnul.obj.vec_.Co<double>
	{
		public Co4dbl((double, double) x) : base(x)
		{
		}

		public Co4dbl(double item1, double item2) : base(item1, item2)
		{
		}
	}
}
