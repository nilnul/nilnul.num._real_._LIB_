
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RI = nilnul.num.RealI;
using Rq = nilnul.num.real_.Quotient;
using nilnul.num._quotient.fraction.op;

using nilnul._num.bigint.be;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

using N = nilnul.Num;//_num.bigint.be.Natural.Asserted;
using Rc = nilnul.num.Real;//.real.all.RealX;




namespace nilnul.num.real.co_.divisible
{
	static public class _DivX
	{
		static public RI Bind(RI a, nilnul.num.real_.NonnilI b) {
			if (object.ReferenceEquals(a, b.real))
			{
				return new nilnul.num.real_.Quotient(1);
			}

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

		static public num.RealI Halve(num.RealI x) {
			return nilnul.num.real.op_.unary_._ScaleX.Op(
				x
				, 
				nilnul.num.Quotient1.CreateHalf()
			);
		}

		public static RI Bind(Q0 a, Rc b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}
		public static RI Bind(Q0 a, RealI b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}

		public static RI Bind(int a, RealI b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}


		public static RI Bind(nilnul.num.real_.Quotient a, RealI b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}

		public static RI Bind(nilnul.num.real_.Quotient a, Real b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(b)
			);
		}


		public static RI Bind(RealI a, nilnul.num.real_.Quotient b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(a, 
				1/b
			);
		}

		public static RI Bind(Rc a, NumI1 b)
		{
			return nilnul.num.real.op_.unary_._ScaleX.Op(
				 nilnul.num.Quotient1.CreateUnit(b)
				,
				 a
			);

		}

		public static RI Bind(Rc a, NumI b)
		{
			return Bind(a, new nilnul.Num1(b) );


		}

		public static RI Bind(Divisible nonegPos)
		{
			return Bind(
				nonegPos.Item1
				,
				nonegPos.Item2
			);

		}
	}
}