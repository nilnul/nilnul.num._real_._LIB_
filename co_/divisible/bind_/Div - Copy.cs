using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RI = nilnul.num.RealI3;
using Rq = nilnul.num.real_.Quotient1;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real.all;
using nilnul._num.bigint.be;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

using N = nilnul.Num;//_num.bigint.be.Natural.Asserted;
using Rc = nilnul.num.Real1;//.real.all.RealX;
using nilnul.num.real.all;



namespace nilnul.num.real.duo_.divisible.bind_
{
	[Obsolete()]
	static public class _DivX
	{
		static public RI Bind(RI a, nilnul.num.real_.NonnilI b) {
			return nilnul.num.real.op_.binary_.Multi.Singleton.op(
				a
				,
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}

		static public RI Bind(RI a, RI b) {
			return Bind(
				a
				,
				new nilnul.num.real_.Nonnil(b)
			);
		}

		static public num.RealI3 Halve(num.RealI3 x) {
			return nilnul.num.real.op_.unary_._ScaleX.Scale(
				x
				, 
				nilnul.num.Quotient1.CreateHalf()
			);
		}

		public static RI Bind(Q0 a, Rc b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Scale(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}

		public static RI Bind(Rc a, NumI b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Scale(
				 nilnul.num.Quotient1.CreateUnit(b)
				,
				 a
			);

		}
	}
}