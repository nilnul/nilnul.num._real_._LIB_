using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real.op_.unary_._square
{
	/// <summary>
	/// </summary>
	public class Ret 
		:_call_.Arg

		,
		RealI
	{
		public Ret(RealI arg) : base(arg)
		{
		}

		public num.quotient.bound_.Closed current => nilnul.num.quotient.bound_.closed.op_.unary_._SqureX.Op(arg.current);

		public void squeeze(Positive1 diameter)
		{
			///todo some ad-hoc optimization needed.
			while (current.diameterGt(diameter))
			{
				arg.Clamp1K();//.squeeze();
			}

		}
	}
}
