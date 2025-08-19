using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient.co;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_._square
{
	/// <summary>
	/// </summary>
	public class Ret 
		:calc_._unary.Arg

		,
		RealI_onQuotient
	{
		public Ret(RealI_onQuotient arg) : base(arg)
		{
		}

		public Clamp current => nilnul.num.quotient.clamp.op_._SqureX.Op(arg.current);

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			///todo some ad-hoc optimization needed.
			while (current.Diameter() >(diameter))
			{
				arg.CinchHalf();//.squeeze();
			}

		}
	}
}
