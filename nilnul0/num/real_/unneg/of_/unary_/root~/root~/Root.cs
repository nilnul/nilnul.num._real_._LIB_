using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul._num.bigint.be_;
using nilnul.num._real.approach.be_;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using P = nilnul._num.bigint.be.Positive;

namespace nilnul.num._real.approach.duo.op_
{
	/// <summary>
	/// the degree must be Positive Natural.
	/// </summary>
	/// <remarks>
	///		Root is a special form of Pow. But root is coded as a standalone type, because we wirte Root expression in a different way (using radical sign) than pow(using superscipt)
	/// </remarks>
	/// 
	[Obsolete(nameof(approach.op_.Root),true)]
	public class Root
	{


		static public ApproachI1 _Eval_radicandPositive(

	BigInteger _randicand__positive,

	nilnul._num.bigint.be.Positive.Asserted root

	)
		{


			if (_randicand__positive == 1)
			{
				return approach_.Quotient.CreateOne();

			}
			if (root == 1)
			{
				return new approach_.Quotient(_randicand__positive);

			}
			return new _root.ret_.PluralPlural(
				new nilnul._num.bigint.be_.Plural.En(_randicand__positive),

				new nilnul._num.bigint.be_.Plural.En(root.val)
			);


		}

		static public ApproachI1 Eval_radicNatural(
					BigInteger _randicand__natural,
					nilnul._num.bigint.be.Positive.Asserted degree
		)
		{
			if (_randicand__natural == 0)
			{
				return new approach_.Quotient();

			}
			if (_randicand__natural == 1)
			{
				return approach_.Quotient.CreateOne();

			}
			if (degree == 1)
			{
				return new approach_.Quotient(_randicand__natural);

			}
			return new _root.ret_.PluralPlural(
				new nilnul._num.bigint.be_.Plural.En(_randicand__natural),

				new nilnul._num.bigint.be_.Plural.En(degree.val)
			);


		}



		static public ApproachI1 Eval(BigInteger radic, P.Asserted degree)
		{

			if (radic >= 0)
			{
				return Eval_radicNatural(radic, degree);

			}
			if (degree.isEven())
			{
				throw new Exception();
			}
			return approach.op_.Negate.Singleton.eval((Eval(-radic, degree)));





		}

		static public ApproachI1 Eval(Q quotient, nilnul._num.bigint.be.Positive.Asserted root)
		{

			return approach.duo_.divisible.op_.Divide._Eval(
				Eval(quotient.numerator, root)
				,
				Eval(quotient.denominator, root)
			);

		}

		[Obsolete("loops reflexive wrong", true)]
		static public ApproachI1 Eval(Q quotient, nilnul._num.bigint.be_.Plural.En root)
		{

			return approach.duo_.divisible.op_.Divide._Eval(
				Eval((Q)quotient.numerator, root)
				,
				Eval(quotient.denominator, root)
			);

		}

		private static ApproachI1 Eval(P.Asserted denominator, Plural.En root)
		{
			return Eval(denominator.val, root);
			//throw new NotImplementedException();
		}

		public static ApproachI1 Eval(BigInteger val, Plural.En root)
		{

			if (val == 1)
			{
				return approach_.Quotient.CreateOne();

			}

			return new _root.ret_.PluralPlural(
				new nilnul._num.bigint.be_.Plural.En(val),

				root
			);

			//throw new NotImplementedException();
		}

		public static ApproachI1 Eval(approach.be_.Nonneg.En a, nilnul._num.bigint.be_.Plural.En degree)
		{

			return new _root.ret_.RadicNonnegR_DegreePlural(a, degree);



			//throw new NotImplementedException();
		}

		public static ApproachI1 Eval(Nonneg.En arg, int v)
		{
			return Eval(
				arg,
				new Plural.En(v)
			);

			throw new NotImplementedException();
		}
	}
}
