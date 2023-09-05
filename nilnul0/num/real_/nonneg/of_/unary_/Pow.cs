using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q = nilnul.num.QuotientI;
using R = nilnul.num.RealI;//.R;//.RealI;


namespace nilnul.num.real_.nonneg.op_.unary_
{
	/// <summary>
	/// 0^-1 is exception
	/// </summary>
	/// <remarks>
	///		Pow(x,y), or x^y, is defined as e^yln(x). So e^x, or op_.Exp must be defined beforehand; that's why we have another operator, op_.Exp, whereas Exp is reserved as an unary operator, which takes e as the radicand<c><see cref="nameof(approach.op_.exp)"/></c>
	///		Cuz x^y is defined as x^ln(y):
	///			1) x >0
	///			2) the result is a single value. we don't have -1 as the result of 1^(1/2). This normalizes(simplifies) the operation. And if you need complexity to have multiple roots, we can extend this op and define another op. Remember our design principals: if part of things can be peeled off into a lower-complex level, divide it; never promote complexity, by merging.
	///			3) due to the above two specification, thank mother Nature, y can be any value negative, 0, or positive. we'll not run into abnormaties.
	/// </remarks>
	static public class _PowX
	{
		//static public nilnul.num.Real Real_radicBeingNil(bool supBeNil)
		//{

		//	return supBeNil ? 1 : 0;
		//}
		static public R RetRealI_assumeRadicPositive1SupNonTrivia(nilnul.num.real_.Quotient radic, nilnul.num.Quotient1 index)
		{

			return real.op_.unary_._RootX.RetRealI(
				real.op_.unary_._IndexX.RetRealI(
					radic, index.numerator
				)
				, index.denominator1
			);

		}

		static public R RetRealI_assumeBaseNonneg(nilnul.num.Quotient1 radic, nilnul.num.Quotient1 index)
		{
			//if (index.denominator1==1)
			//{
			//	return nilnul.num.real_.nonnil.op_.unary_._IndexX.RetRealI(radic, index.numerator);
			//}

			return real.op_.unary_._RootX.RetRealI(
				real_.nonneg.op_.unary_._IndexX.RetRealI(
					radic, index.numerator
				)
				, index.denominator1
			);

		}

		static public R RetRealI(nilnul.num.Quotient1 radic, nilnul.num.Quotient1 index)
		{
			//if (index.denominator1==1)
			//{
			//	return nilnul.num.real_.nonnil.op_.unary_._IndexX.RetRealI(radic, index.numerator);
			//}

		

			return real.op_.unary_._RootX.RetRealI(
				real_.nonneg.op_.unary_._IndexX.RetRealI(
					radic, index.numerator
				)
				, index.denominator1
			);

		}

		


		static public R RetRealI_radicUnsureQuotient_assumeSupNotTrivia(nilnul.num.real_.NonnegI radic, nilnul.num.Quotient1 i)
		{

			return real.op_.unary_._RootX.RetRealI(
				real_.nonneg.op_.unary_._IndexX.RetRealI(
				radic, i.numerator
				)       // if the denominator is even, exception is thrown; for odd denominator, the index can have both num and denominator muliplied by two and hence exception.
				, i.denominator1
			);
		}


		static public nilnul.num.RealI _RealI_assumeSupNotTrivia(nilnul.num.real_.NonnegI real, nilnul.num.Quotient1 sup)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(real))
			{
				return RetRealI_assumeRadicPositive1SupNonTrivia(real.current.lower.mark, sup);
			}
			return RetRealI_radicUnsureQuotient_assumeSupNotTrivia(real, sup);

		}

		static public nilnul.num.RealI _RealI_assumeSupNotInteger(nilnul.num.real_.NonnegI real, nilnul.num.Quotient1 sup)
		{
			if (sup.numerator == 1)
			{
				return real_.nonneg. op_.unary_._RootX.RetRealI(real, sup.denominator1);
			}
			return _RealI_assumeSupNotTrivia(real, sup);
		}


	


		/// <summary>
		/// 
		/// </summary>
		/// <param name="radic">if this one is negtive, this is not well defined, due to </param>
		/// <param name="i"></param>
		/// <returns></returns>
		static public R RetRealI(nilnul.num.real_.NonnegI radic, nilnul.num.Quotient1 i)
		{
			if (i.denominator1 == 1)
			{
				return real_.nonneg.op_.unary_. _IndexX.RetRealI(radic, i.numerator);
			}

	
			return _RealI_assumeSupNotInteger(radic, i);


		}
		public static R RetRealI_makeBaseNonneg(R radic, Quotient1 mark)
		{
			return RetRealI(new nilnul.num.real_.Nonneg(radic),mark);
		}





	}
}
