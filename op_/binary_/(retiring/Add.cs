using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.duo.op_
{
	public  class Add
		: OpI
	{

		static public readonly Add Singleton = SingletonByDefault<Add>.Instance;

		public const char Sign = '+';

		static public ApproachI1 Eval(ApproachI1 a, ApproachI1 b)
		{

			return new _add.Call(a, b);

			throw new NotImplementedException();

		}
		static public ApproachI1 Eval(Q1 a, ApproachI1 b)
		{
			return Eval(
				new approach_.Quotient(a), b

			);

		}

		static public ApproachI1 Square(ApproachI1 a)
		{

			return new _add.Call(a, a);

			throw new NotImplementedException();

		}

		public Approach1 eval(Approach1 a, Approach1 b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

	}
}
