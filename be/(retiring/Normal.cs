using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_.b
{
	/// <summary>
	/// no NaN, no Inf, NegInf
	/// </summary>
	public class Normal
		: nilnul.obj.BI<double>
	{

		static public bool Eval(double d) {
			return !( double.IsNaN(d) || double.IsInfinity(d) );

		}
		public bool be(double d)
		{
			return !( double.IsNaN(d) || double.IsInfinity(d) );

			throw new NotImplementedException();
		}

		public class Asserted:nilnul.obj.Asserted<double,Normal>
		{

			public Asserted(double val):base(val)
			{
				
			}
		}
	}
}
