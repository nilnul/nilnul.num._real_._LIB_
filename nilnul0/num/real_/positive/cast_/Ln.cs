using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
using q_ = nilnul.num.quotient_;

namespace nilnul.num.real_.positive.cast_.sup_
{
	[Obsolete("too slow see {nameof(ln_.ByReverseExp)}",true)]
	static public class _LnX
	{
		static public R Convert(
					q_.Positive1 arg
		)
		{
			return new _ln.ret_.OfQ(
				arg
			);
		}


		static public R Convert(
			Q1 q
			)
		{
			return Convert(
				 new q_.Positive1(q)
			);
		}

		static public R Convert(
					real_.Positive arg
		)
		{
			return new _ln.Ret(
				arg
			);
		}
		internal static R Convert(R par)
		{
			return Convert(new real_.Positive(par));
		}

		static public R Convert(
					real_.PositiveI arg
		)
		{
			return Convert(
			 new real_.Positive(	arg)
			);
		}





	}
}
