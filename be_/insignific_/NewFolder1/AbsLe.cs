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
	public class AbsLe
		:
		nilnul.obj.Box<nilnul.num.quotient_.NonnegI>
		,
		nilnul.num.real.BeI
	{
		public AbsLe(NonnegI val) : base(val)
		{
		}

		public AbsLe(num.quotient_.Nonneg val) : this((NonnegI)val)
		{
		}

		public AbsLe(nilnul.num.Quotient1 quotient):this(new nilnul.num.quotient_.Nonneg(quotient))
		{
		}

		public AbsLe(int i):this(new num.Quotient1(i))
		{
		}

		public AbsLe(double x):this(
			nilnul.num.quotient_._DblX.Constuct(x)
		)
		{

		}
		public  bool be(RealI x)
		{
			return  nilnul.num.real.op_.unary_.Abs.Singleton.op(x).ToReal() <= boxed.vowed;
		}
		

		

	}
}
