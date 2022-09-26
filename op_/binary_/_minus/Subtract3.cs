using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;

namespace nilnul.num.real.op
{

	[Obsolete("wrong namespace")]
	public partial class Subtract3
	{
		static public R Eval(R a, int b) {
			return Eval(a, new real.Rational_posConverge2Bounded( b));
		}
		static public R Eval(R a,R b) {

			return Add_posConverge2bounded.Eval(a, Negate_posConverge2bounded.Eval(b));

			throw new NotImplementedException();
		
		}

	}
}
