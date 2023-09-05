using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;
using nilnul.num.real_.nonneg.be_;

namespace nilnul.num.real.be_
{
	public class Insignificant4dbl

		:
		nilnul.obj.Box_ofIn<nilnul.num.real_.nonneg.be_.Small4dbl>
		,
		nilnul.num.real.IBeOfDouble
		,
		IInsignificant
	{
		public Insignificant4dbl(in Small4dbl val) : base(val)
		{
		}

		public Insignificant4dbl(Small4dbl x) : base(x)
		{
		}
		public Insignificant4dbl(nilnul.num.real_.NonnegOfDouble val) : this(new Small4dbl(val))
		{
		}

	

		public Insignificant4dbl(int i):this(new nilnul.num.real_.NonnegOfDouble(i))
		{
		}

		public Insignificant4dbl(double x):this(
			new nilnul.num.real_.NonnegOfDouble(x)
		)
		{

		}


		public  bool be(double x)
		{
			return boxed._be_0finiteNonneg( nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x));
		}

		static public Insignificant4dbl CreateByAbs(double x) {
			return new Insignificant4dbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}
		

		

	}
}
