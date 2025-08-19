using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;
using nilnul.num.real_;


namespace nilnul.num.real.be_
{
	public class Insignific
		:
		nilnul.obj.Box_ofIn<nilnul.num.quotient_.denomNonnil_.Nonneg>
		,
		nilnul.num.real.BeI_onQuoient
	{
	

		public Insignific(num.quotient_.denomNonnil_.Nonneg val) : base(val)
		{
		}

	

		public Insignific(int i):this(new num.quotient_.denomNonnil_.Nonneg(i))
		{
		}

		public Insignific(double x)
			:
			this(
			nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.to_._ToRationalX.ToSignificed(x).toDenomNonnil()
		)
		{

		}

		public Insignific(Q4 i):this(new num.quotient_.denomNonnil_.Nonneg(i)) 
		{
		}

		

		public bool be(in R0 x)
		{
			return  nilnul.num.real.op_.Abs.Singleton.op(x).ToImpl() <= boxed.eeByRef;

		}
	}
}
