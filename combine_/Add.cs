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
using Q0 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.combine_
{
	public  class Add
		: CombineI
	{
		public const char Sign = '+';

		static public R1 Op(R1 a, R1 b)
		{
			if (object.ReferenceEquals(a,b))
			{
				return op_.unary_._ScaleX.Scale(2, a);
			}
			return new op_.binary_._add.Ret(a, b);
		}

		static public R1 Op(Q0 a, R1 b)
		{
			return  op_.unary_._ShiftX.Op(a,b);

		}

		static public R1 Op(nilnul.num.real_.Quotient a, R1 b)
		{
			return  op_.unary_._ShiftX.Op(a,b);
		}

		static public R1 Op(nilnul.num.real_.Quotient a, Real b)
		{
			return  op_.unary_._ShiftX.Op(a,b);
		}

		static public R1 Double(R1 a)
		{
			return new op_.binary_. _add.Ret(a, a);
		}

		public R1 combine(R1 a, R1 b)
		{
			return Op(a, b);
		}
		public R1 combine(Q0 a, R1 b)
		{
			return Op(a, b);
		}

		public R1 combine( R1 b, Q0 a)
		{
			return Op(a, b);
		}

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}


	}
}
