using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real_.nonneg.be_
{
	public class Small
		:
		nilnul.obj.Box_ofIn<nilnul.num.real_.NonnegI>
		,
		nilnul.num.real_.nonneg.BeI
	{
		public Small(NonnegI val) : base(val)
		{
		}

		public Small(num.quotient_.Nonneg val) : this((NonnegI)val)
		{
		}

		public Small(nilnul.num.Quotient1 quotient):this(new nilnul.num.quotient_.Nonneg(quotient))
		{
		}

		public Small(int i):this(new num.Quotient1(i))
		{
		}

		public Small(double x):this(
			nilnul.num.quotient_._DblX.Constuct(x)
		)
		{

		}
		public bool be(in NonnegI val)
		{
			return val.ToReal()<= boxed.realee.en;

		}
	}
}
