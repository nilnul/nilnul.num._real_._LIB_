using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.be_
{
	public class AbsLeDbl
		:
		nilnul.obj.Box<nilnul.num.real_.NonnegOfDouble>
		,
		nilnul.num.real.IBeOfDouble
	{
		public AbsLeDbl(nilnul.num.real_.NonnegOfDouble val) : base(val)
		{
		}

	

		public AbsLeDbl(int i):this(new nilnul.num.real_.NonnegOfDouble(i))
		{
		}

		public AbsLeDbl(double x):this(
			new nilnul.num.real_.NonnegOfDouble(x)
		)
		{

		}
		public  bool be(double x)
		{
			return  nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x) <= boxed;
		}

		static public AbsLeDbl CreateByAbs(double x) {
			return new AbsLeDbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}
		

		

	}
}
