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

namespace nilnul.num.real_.nonneg.op_.unary_
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
		static public RealI RetRealI(
			nilnul.num.quotient_.Nonneg nonNegQ
				,
			nilnul.num_.Plural1 positiveN
		)
		{
			if (nonNegQ == 0)
			{
				return new real_.Quotient();
			}
			if (nonNegQ < 1)
			{
				//return nilnul.num.real_.nonnil.op_.unary_._InverseX1.Op( 
				return new _root.ret_.PositiveProperQ_PluralN(
					new num.quotient.be_.positive_.ltOne.vow.En(nonNegQ.en)
					,
					new nilnul.num_.Plural1(positiveN)
				);
			}
			if (nonNegQ == 1)
			{
				return real_.Quotient.CreateOne();
			}

			return new _root.ret_.GtOneQ_PluralN(
				new num.quotient.be_.gtOne.vow.En(nonNegQ.en)
				,
				new nilnul._num.bigint.be_.Plural.En(positiveN)
			);
		}
		static public RealI RetRealI(
			nilnul.num.quotient_.Nonneg nonNegQ
				,
			nilnul.num_.Positive1 positiveN
		)
		{

			if (positiveN.en == 1)
			{
				return new nilnul.num.real_.Quotient(1);
			}
			return RetRealI(nonNegQ, new num_.Plural1(positiveN));

		}

		static public RealI RetRealI(
			nilnul.num.quotient_.Nonneg nonNegQ
				,
			nilnul.Num1 index
		)
		{
			return RetRealI(nonNegQ, new nilnul.num_.Positive1(index));

		}


		static public RealI RetRealI(
			nilnul.num.Quotient1 quotient_nonNeg
			,
			nilnul.num_.Positive1 root
		)
		{

			return RetRealI(
				new num.quotient_.Nonneg(quotient_nonNeg)
				, root

			);

		}

		static public nilnul.num.RealI RetRealI(
			nilnul.num.Quotient1 quotient_nonNeg
			,
			nilnul.Num1 root
		)
		{


			return RetRealI(
				new num.quotient_.Nonneg(quotient_nonNeg)
				,
				new nilnul.num_.Positive1(
				root
				)
			);

		}



		static public RealI RetRealI(
			nilnul.num.Quotient1 quotient
			,
			nilnul.num_.Plural1 root
		)
		{

			return RetRealI(
				new num.quotient_.Nonneg(quotient)
				,
				(root)

			);

		}

		#region real


		public static RealI RetRealI(
			real_.NonnegI radicand
			,
			nilnul.num_.Plural degree
		)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(radicand))
			{
				return RetRealI(
					(radicand.current.lower.mark)
					, degree
				);

			}
			return (
				new _root.ret_.RadicNonnegR_DegreePlural(
					radicand,
					degree
				)
			);
		}
		public static real_.Nonneg RetNonneg(
				  real_.NonnegI radicand
				  ,
				  nilnul.num_.Plural degree
			 )
		{

			return new nilnul.num.real_.Nonneg(
				 RetRealI(
					radicand,
					degree
				)
			);
		}



		public static real_.NonnegI RetNonnegI(
			real_.NonnegI radicand
			,
			nilnul.num_.Positive1 degree
		)
		{


			if (degree == 1)
			{
				return radicand;
			}

			return RetNonneg(
				radicand,
				new num_.Plural(
					degree
				)

			);
		}
		public static RealI RetRealI(
			RealI radicand
			,
			nilnul.num_.Plural degree
		)
		{



			return RetRealI(
				new nilnul.num.real_.Nonneg(radicand)
				,
				new num_.Plural(
					degree
				)

			);

		}
		public static RealI RetRealI(
			RealI radicand
			,
			nilnul.num_.Positive1 degree
		)
		{

			if (degree == 1)
			{
				return radicand;
			}

			return RetRealI(
				(radicand)
				,
				new num_.Plural(
					degree
				)

			);

		}
		public static real_.NonnegI RetNonnegI(
			RealI radicand
			,
			nilnul.num_.Positive1 degree
		)
		{
			return new real_.Nonneg(RetRealI(
				new nilnul.num.real_.Nonneg(radicand)
				,
				degree
			));
		}

		public static NonnegI RetNonnegI(real_.NonnegI arg, int v)
		{
			return RetNonnegI(arg, new nilnul.num_.Positive1(v));
		}
		#endregion

	}


}
