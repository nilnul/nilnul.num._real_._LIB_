using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q = nilnul.num.QuotientI;
using R = nilnul.num.RealI;//.R;//.RealI;


namespace nilnul.num.real.co_.starT_.positive
{
	/// <summary>
	/// by exp^(base* ln(sup) )
	/// </summary>
	/// <remarks>
	/// 0^-1 is exception
	///		Pow(x,y), or x^y, is defined as e^yln(x). So e^x, or op_.Exp must be defined beforehand; that's why we have another operator, op_.Exp, whereas Exp is reserved as an unary operator, which takes e as the radicand<c><see cref="nameof(approach.op_.exp)"/></c>
	///		Cuz x^y is defined as x^ln(y):
	///			1) x >0
	///			2) the result is a single value. we don't have -1 as the result of 1^(1/2). This normalizes(simplifies) the operation. And if you need complexity to have multiple roots, we can extend this op and define another op. Remember our design principals: if part of things can be peeled off into a lower-complex level, divide it; never promote complexity, by merging.
	///			3) due to the above two specification, thank mother Nature, y can be any value negative, 0, or positive. we'll not run into abnormaties.
	/// </remarks>
	///
	[Obsolete("per testing, in some cases, very slow")]
	static public class _PowX
	{


		static public nilnul.num.RealI RetRealI_assumeRadicPositive(nilnul.num.Quotient1 radic, nilnul.num.RealI index)
		{

			if (radic == 1)
			{
				return new nilnul.num.real_.Quotient(1);
			}

			return nilnul.num.real.op_.unary_.Exp.RetRealI(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					index
					,
					nilnul.num.real_.positive.ln_._ByReverseExpX.RetRealI(radic)
				)

			);
		}



		static public nilnul.num.RealI RetRealI_ofSupMayIrrational(nilnul.num.real_.PositiveI radic, nilnul.num.RealI index)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(radic))
			{
				return RetRealI_assumeRadicPositive(radic.current.lower.mark, index);
			}
			
			return nilnul.num.real.op_.unary_.Exp.RetRealI(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					index
					,
					nilnul.num.real_.positive.ln_._ByReverseExpX.RetRealI(radic)
				)

			);
		}



		static public nilnul.num.RealI RetRealI(nilnul.num.real_.PositiveI radic, nilnul.num.RealI index)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(index))
			{
				return real_.positive.op_.unary_._PowX.RetRealI(radic, index.current.lower.mark);
			}
			return RetRealI_ofSupMayIrrational(radic, index);

		}

		public  static R RetRealI(R radic, R index)
		{
			return RetRealI(new real_.Positive(radic),index);

		}

		static public nilnul.num.real_.Positive RetPositive(nilnul.num.real_.PositiveI radic, nilnul.num.RealI index)
		{

			return new nilnul.num.real_.Positive(RetRealI(radic, index));
		}

		public static nilnul.num.RealI RetRealI(Quotient1 radic, Quotient1 index)
		{
			return real_.positive.op_.unary_._PowX.RetRealI_makeBasePositive(radic, index);
		}

		public static nilnul.num.Real RetReal(Quotient1 radic, Quotient1 index)
		{
			return new Real(RetRealI(radic,index));
		}

		public static Real RetReal(R radic, R index)
		{
			return new Real(RetRealI(radic,index));
		}


		//[Obsolete( nameof(RetPositive))]
		//public static nilnul.num.real_.Nonneg RetNonneg(R radic, R index)
		//{
		//	return RetNonneg(new nilnul.num.real_.Positive(radic), index);
		//}
	}
}
