using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul._num.bigint.be_;
using Q = nilnul.num.QuotientI;
using P = nilnul._num.bigint.be.Positive;
using nilnul.num_;

namespace nilnul.num.real_.positive.op_.unary_
{
	/// <summary>
	/// the degree must be Positive Natural.
	/// </summary>
	/// <remarks>
	///		Root is a special form of Pow. But root is coded as a standalone type, because we wirte Root expression in a different way (using radical sign) than pow(using superscipt)
	///		
	///		To align with real.duo_.Pow x^y=e^(y ln(x) ). We allow one exception: when x=0, 'cuz when x --> 0+, ln(x) --> -inf, and the result is zero. 
	/// </remarks>
	static public class _RootX
	{
		static public RealI RetReal(
			nilnul.num.quotient_.Positive1 nonNegQ
				,
			nilnul.num_.Plural1 positiveN
		)
		{

			if (nonNegQ.en < 1)
			{
				//return nilnul.num.real_.nonnil.op_.unary_._InverseX1.Op( 
				return new nonneg.op_.unary_._root.ret_.PositiveProperQ_PluralN(
					new num.quotient.be_.positive_.ltOne.vow.En(nonNegQ.en)
					,
					new nilnul.num_.Plural1(positiveN)
				);
			}
			if (nonNegQ.en == 1)
			{
				return real_.Quotient.CreateOne();
			}

			return new nonneg.op_.unary_._root.ret_.GtOneQ_PluralN(
				new num.quotient.be_.gtOne.vow.En(nonNegQ.en)
				,
				new nilnul._num.bigint.be_.Plural.En(positiveN)
			);
		}

		static public RealI RetReal(
			nilnul.num.quotient_.Positive1 nonNegQ
				,
			nilnul.num_.Positive1 positiveN
		)
		{

			if (positiveN.en == 1)
			{
				return new nilnul.num.real_.Quotient(nonNegQ);
			}
			return RetReal(nonNegQ, new num_.Plural(positiveN));

		}

		static public RealI RetReal(
			nilnul.num.quotient_.Positive1 nonNegQ
				,
			nilnul.NumI1 positiveN
		)
		{

			return RetReal(nonNegQ, new num_.Positive1(positiveN));

		}




		static public nilnul.num.RealI RetReal(
			nilnul.num.QuotientI quotient_nonNeg
			,
			nilnul.Num1 root
		)
		{


			return RetReal(
				new num.quotient_.Positive1(quotient_nonNeg)
				,

				root

			);

		}

		static public RealI RetReal(
			Q quotient_nonNeg
			,
			nilnul.NumI1 root
		)
		{

			return RetReal(
				(quotient_nonNeg)
				,
				new nilnul.Num1(
				root)



			);

		}

		//[Obsolete(PluralPlural_ceded4_Q, true)]
		static public RealI RetReal(
			Q quotient
			,
			nilnul.num_.Plural root
		)
		{

			return RetReal(
				new num.quotient_.Positive1(quotient)
				,
				(root)

			);

		}

		public static RealI RetRealI(
			real_.PositiveI radicand
			,
			nilnul.num_.Plural degree
		)
		{
			return (
				new num.real_.nonneg.op_.unary_._root.ret_.RadicNonnegR_DegreePlural(radicand,

						degree

				)
			);

		}

		public static RealI RetRealI(
			real_.Positive radicand
			,
			nilnul.num_.Plural degree
		)
		{
			return (
				new num.real_.nonneg.op_.unary_._root.ret_.RadicNonnegR_DegreePlural(radicand,

						degree

				)
			);

		}

		public static RealI RetRealI(
			real_.PositiveI radicand
			,
			nilnul.num_.Positive1 degree
		)
		{

			if (degree == 1)
			{
				return radicand;
			}
			return (
				 RetRealI(radicand,
					new num_.Plural(
						degree
					)
				)
			);
		}

		public static RealI RetRealI(
			real_.Positive radicand
			,
			nilnul.num_.Positive1 degree
		)
		{

			if (degree == 1)
			{
				return radicand;
			}
			return (
				 RetRealI(radicand,
					new num_.Plural(
						degree
					)
				)
			);
		}

		public static real_.Positive RetPositive(
			real_.Positive radicand
			,
			nilnul.num_.Positive1 degree
		)
		{
			return new nilnul.num.real_.Positive(
				RetRealI(radicand, degree)
			);
		}

	


		public static real_.Positive RetPositive(
			real_.PositiveI radicand
			,
			nilnul.num_.Positive1 degree
		)
		{
			return RetPositive(new Positive(radicand), degree);
		}


		public static real_.Positive RetPositive(PositiveI arg, int v)
		{
			return RetPositive(arg, new num_.Positive1(v));
		}
		public static real_.Positive RetPositive(real_.Positive arg, int v)
		{
			return RetPositive(arg, new num_.Positive1(v));
			;
		}

		public static real_.Positive RetPositive(num.RealI arg, int v)
		{
			return RetPositive(new num.real_.Positive(arg), v);
			;
		}
	}
}
