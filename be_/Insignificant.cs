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
	public class Insignificant
		:
		nilnul.obj.Box<nilnul.num.quotient_.NonnegI>
		,
		nilnul.num.real.BeI
	{
		public Insignificant(NonnegI val) : base(val)
		{
		}

		public Insignificant(num.quotient_.Nonneg val) : this((NonnegI)val)
		{
		}

		public Insignificant(nilnul.num.Quotient1 quotient):this(new nilnul.num.quotient_.Nonneg(quotient))
		{
		}

		public Insignificant(int i):this(new num.Quotient1(i))
		{
		}

		public Insignificant(double x):this(
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
