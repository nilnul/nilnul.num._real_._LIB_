using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q = nilnul.num.QuotientI;
using R = nilnul.num.RealI;//.R;//.RealI;


namespace nilnul.num.real.co_.starT_.positive.pow_
{

	//[Obsolete("sup is irrational, making the boundEnd of base not easy to find bound ", true)]

	[Obsolete("too slow(overnight)",true)]
	static public class _ByOpSupBorderX
	{

		static public nilnul.num.RealI RetRealI_assumeRadicPositive(nilnul.num.Quotient1 radic, nilnul.num.RealI index)
		{

			if (radic == 1)
			{
				return new nilnul.num.real_.Quotient(1);
			}

			return new _byOpSupBorder.Ret( radic,index);
		}



		static public nilnul.num.RealI RetRealI_ofSupMayIrrational(nilnul.num.real_.PositiveI radic, nilnul.num.RealI index)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(radic))
			{
				return RetRealI_assumeRadicPositive(radic.current.lower.mark, index);
			}
			return new _byOpSupBorder.Ret( radic,index);

			
		}


		static public nilnul.num.RealI RetRealI(nilnul.num.RealI radic, nilnul.num.RealI index)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(index))
			{
				return num.real_.positive.op_.unary_._PowX.RetRealI_willMakeBasePositive(radic, index.current.lower.mark);
			}
			return  RetRealI_ofSupMayIrrational( new real_.Positive( radic),index);
		}

		static public nilnul.num.RealI RetRealI_ofRadicGtOne(nilnul.num.RealI radic, nilnul.num.RealI index)
		{
			return new _byOpSupBorder.ret_.RadicGtOne( radic,index);
		}


		static public nilnul.num.Real RetReal_ofRadicGtOne(nilnul.num.RealI radic, nilnul.num.RealI index)
		{
			return new Real(RetRealI_ofRadicGtOne( radic,index));
		}

		static public nilnul.num.RealI RetRealI(nilnul.num.real_.PositiveI radic, nilnul.num.RealI index)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(index))
			{
				return real_.positive.op_.unary_._PowX.RetRealI(radic, index.current.lower.mark);
			}
			return RetRealI_ofSupMayIrrational(radic, index);

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
			return new Real(RetRealI(radic, index));
		}

		public static Real RetReal(R radic, R index)
		{
			return new Real(RetRealI(radic, index));
		}


	}
}
