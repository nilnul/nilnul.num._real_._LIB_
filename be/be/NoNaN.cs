using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_.b
{
	/// <summary>
	/// no NaN, but having Inf, NegInf
	/// </summary>
	public class NoNaN
		: nilnul.obj.BI<double>
	{
		public bool be(double d)
		{
			return !( double.IsNaN(d)  );

			throw new NotImplementedException();
		}

		public class Asserted:nilnul.obj.Asserted<double,NoNaN>
		{

			public Asserted(double val):base(val)
			{
				
			}
		}
	}
}
