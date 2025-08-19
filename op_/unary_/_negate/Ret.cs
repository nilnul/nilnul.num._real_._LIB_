using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using R = nilnul.num.RealI3;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num.quotient;

namespace nilnul.num._real._cauchy.approach.op_.unary_._negate
{


	public class Ret
		: _call.Arg
		,
		ApproachI

	{
		public Ret(ApproachI arg) : base(arg)
		{

		}

		

		public Range1 range =>-arg.range;
		public void squeeze(quotient_.Positive1 diameter)
		{

			arg.squeeze(diameter);
			return;
		}

	}

	public static class RetX
	{
		static public ApproachI Negate(this ApproachI x)
		{
			return new Ret(x);
		}

	}
}
