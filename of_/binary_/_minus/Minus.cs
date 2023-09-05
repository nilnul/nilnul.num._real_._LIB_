using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num._real._cauchy.approach.op_.binary_
{
	public  class Minus
		: BinaryI
	{

		static public readonly Minus Singleton = SingletonByDefault<Minus>.Instance;

		public const char Sign = '-';

		static public ApproachI Op(ApproachI a, ApproachI b)
		{

			return new _minus.Ret(a, b);


		}
		static public ApproachI Op(Q1 a, ApproachI b)
		{
			return op_.binary_.Add.Singleton.op(
				a, 
				op_.unary_.Negate.Singleton.op(
					b
				)
			);

		}

			static public ApproachI Op( ApproachI b, Q1 a)
		{
			return op_.binary_.Add.Singleton.op(
				b, 
				
					-a
				
			);

		}


		public ApproachI op(ApproachI a, ApproachI b)
		{
			return Op(a, b);
		}

	}
}
