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


namespace nilnul.num._real.approach.op_
{
	/// <summary>
	/// the degree must be Positive Natural.
	/// </summary>
	/// <remarks>
	///		Root is a special form of Pow. But root is coded as a standalone type, because we wirte Root expression in a different way (using radical sign) than pow(using superscipt)
	///		
	///		To align with real.duo_.Pow x^y=e^(y ln(x) ). We allow one exception: when x=0, 'cuz when x --> 0+, ln(x) --> -inf, and the result is zero. 
	/// </remarks>
	public class Root
	{



		static public ApproachI1 Eval(
	nilnul.num.quotient.be_.Nonneg.En nonNegQ
		,
	nilnul._num.bigint.be.Positive1.Asserted positiveN

	)
		{

			if (nonNegQ == 0)
			{
				return new approach_.Quotient();
			}

			if (nonNegQ == 1)
			{
				return approach_.Quotient.CreateOne();
			}

			if (positiveN == 1)
			{
				return new approach_.Quotient(nonNegQ.val);
			}

			if (nonNegQ < 1)
			{
				return new _root.ret_.PositiveProperQ_PluralN(
					new quotient.be_.positive.Proper.En(nonNegQ.val)
					,
					new Plural.En(positiveN)
				);

			}
			return new _root.ret_.GtOneQ_PluralN(
				new quotient.be_.GtOne.En(nonNegQ.val)
				,
				new Plural.En(positiveN)
			);




		}
		[Obsolete("not necessary for a dedicated PluralPluarl as we can use a unified Q_PluralN", true)]
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

		public const string PluralPlural_ceded4_Q = "not necessary for a dedicated PluralPluarl as we can use a unified Q_PluralN";

		[Obsolete(PluralPlural_ceded4_Q, true)]
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


		[Obsolete(PluralPlural_ceded4_Q, true)]

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

		static public ApproachI1 _Eval(
			Q quotient_nonNeg
			,
			nilnul._num.bigint.be.Positive1.Asserted root
		)
		{

			return Eval(
				new quotient.be_.Nonneg.En(quotient_nonNeg)
				,root
				
			);

		}

		static public ApproachI1 _Eval(
			Q quotient_nonNeg
			,
			nilnul._num.bigint.be.Positive.Asserted root
		)
		{

			return Eval(
				new quotient.be_.Nonneg.En(quotient_nonNeg)
				,
				new Positive1.Asserted(
				root
				)

				
			);

		}

		//[Obsolete(PluralPlural_ceded4_Q, true)]
		static public ApproachI1 Eval(
			Q quotient
			,
			nilnul._num.bigint.be_.Plural.En root
		)
		{

			return Eval(
				new num.quotient.be_.Nonneg.En(quotient)
				, 
				new Positive1.Asserted( root.val)
				
			);

		}

		private static ApproachI1 Eval(
			P.Asserted radicand,
			Plural.En root
		)
		{
			return Eval(
				new quotient.be_.Nonneg.En(radicand.val),
				new Positive1.Asserted(root.val)
			); //  Eval( denominator.val, root);
			   //throw new NotImplementedException();
		}



		[Obsolete(PluralPlural_ceded4_Q, true)]
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

		public static ApproachI1 Eval(
				approach.be_.Nonneg.En radicand
				,
				nilnul._num.bigint.be.Positive1.Asserted degree)
		{
			/// we here not try to clamp radicand, for that's too expensive or even perpetual; But we only need the result and clamp later when necessary.

			

			if (degree == 1)
			{
				return radicand;
			}

			return new _root.ret_.RadicNonnegR_DegreePlural(
				radicand, 
				new Plural.En(degree)	
			);
		}

		public static ApproachI1 Eval(
	approach.be_.Nonneg.En radicand
	,
	nilnul._num.bigint.be_.Plural.En degree)
		{
			/// we here not try to clamp radicand, for that's too expensive or even perpetual; But we only need the result and clamp later when necessary.

			return new _root.ret_.RadicNonnegR_DegreePlural(radicand, degree);
		}





		public static ApproachI1 _Eval(Nonneg.En arg, int _degree_nonNeg)
		{
			return Eval(
				arg,
				new nilnul._num.bigint.be.Positive1.Asserted(_degree_nonNeg)
			);

			//throw new NotImplementedException();
		}
	}
}
