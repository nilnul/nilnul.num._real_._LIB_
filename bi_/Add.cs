using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI;//.real.RealI_posConverge2NonEmpty;
using A = nilnul.num.RealI;
using R1 = nilnul.num.RealI;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.Quotient1;
using nilnul.num.quotient_;
using System.Numerics;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.bi_
{
	public class Add
		:
		real.Bi8dblA

		
		,
		op_.BinaryI
		,
		real.of_.Binary4dblI
		,
		of_.BinaryI

	{


		public const char Sign = '+';
		public RealI_onQuotient op(RealI_onQuotient a, RealI_onQuotient b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return op_._ScaleX.Op(2, a);
			}

			if (nilnul.num.real.be_.Quotient.Singleton.be(a))
			{
				return op_._ShiftX.Op(a.current.begin, b);
			}
			if (nilnul.num.real.be_.Quotient.Singleton.be(b))
			{
				return op_._ShiftX.Op(b.current.begin, a);
			}



			return new of_.binary_._add.Ret(a, b);

		}

		static public R1 Op(R1 a, R1 b)
		{

			if (object.ReferenceEquals(a, b))
			{
				return op_.unary_._ScaleX.Scale(2, a);
			}

			if (nilnul.num.real.be_.Quotient.Singleton.be(a))
			{
				return op_.unary_._ShiftX.Op(a.current.lower.mark, b);
			}
			if (nilnul.num.real.be_.Quotient.Singleton.be(b))
			{
				return op_.unary_._ShiftX.Op(b.current.lower.mark, a);
			}



			return new op_.binary_._add.Ret(a, b);


		}
		static public R1 Op(Q0 a, R1 b)
		{
			return op_.unary_._ShiftX.Op(a, b);

		}
		static public R1 Op(nilnul.num.real_.Quotient a, R1 b)
		{
			return op_.unary_._ShiftX.Op(a, b);

		}

		static public R1 Op(nilnul.num.real_.Quotient a, Real b)
		{
			return op_.unary_._ShiftX.Op(a, b);

		}

		public R0 op(DenomNonnilI a, Real_onQuotient b)
		{
			return op_._ShiftX.Op(a, b);

		}

		static public R1 Double(R1 a)
		{

			return new op_.binary_._add.Ret(a, a);


		}

		public R1 op(R1 a, R1 b)
		{
			return Op(a, b);
		}
		public R1 op(Q0 a, R1 b)
		{
			return Op(a, b);
		}

		public R1 op(R1 b, Q0 a)
		{
			return Op(a, b);
		}

		public double op(double par, double par1)
		{
			return par + par1;
		}

		public override double _op_01finite(double x, double y)
		{
			return x + y;
			//throw new NotImplementedException();
		}

		public R0 op(R0 result, BigInteger bigInteger)
		{
			return real.op_._ShiftX.Op(bigInteger, result);
		}

		public R0 op(Real_onQuotient a, Q4 denomNonnil)
		{
			return real.op_._ShiftX.Op(denomNonnil, a);

		}

		public R0 op(int v, Real_onQuotient r)
		{
			return real.op_._ShiftX.Op(v, r);
		}

		public R0 op(int v, R0 r)
		{
			return real.op_._ShiftX.Op(v, r);

		}

		public R0 op(DenomNonnilI v, R0 r)
		{
			return real.op_._ShiftX.Op(v, r);

		}

		static public Add Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Add>.Instance;
			}
		}



	}
}
