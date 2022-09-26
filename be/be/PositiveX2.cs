using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.b
{

	public class Positive
		:nilnul.obj.B<double>
	{
		static public bool Eval(double x)
		{
			return Normal.Eval(x) &&  x > 0;
		}

		public Positive()
			:base(Eval)
		{

		}

		public class Asserted:nilnul.obj.Asserted<double,Positive>
		{
			public Asserted(double val):base(val)
			{

			}

			static public implicit operator double (Asserted x) {
				return x.val;
			}
		}

		




	}
}