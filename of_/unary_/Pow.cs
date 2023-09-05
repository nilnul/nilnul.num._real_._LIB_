using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{


	/// <summary>
	/// to the power of quotient; for power of real, using binary_.Pow
	/// </summary>
	/// <remarks>
	///nomenclature:
	///		raised to the Power
	///		sup
	/// </remarks>
	public interface PowI : UnaryI
	{
	}

	static public class _PowX
	{
	
		static public nilnul.num.RealI _RealI_baseUnsureQuotient_assumeSupNotTrivia(nilnul.num.RealI real, nilnul.num.Quotient1 sup)
		{

			// such as -3/4 so the radic cannot be 0 or neg in this case
			// but for -3/5 the radic can be negative, but not nil.
			return op_.unary_._RootX.RetRealI(
				op_.unary_._IndexX.RetRealI(
					real
					,
					sup.numerator
				)       // if the denominator is even, exception is thrown; for odd denominator, the index can have both num and denominator muliplied by two and hence exception.
				, sup.denominator1
			);

		}


		static public nilnul.num.RealI _RealI_assumeSupNotTrivia(nilnul.num.Quotient1 real, nilnul.num.Quotient1 sup)
		{
			//if (real == 0)
			//{
			//	return Real_radicBeingNil(sup == 0);
			//}
			//if (real == 1)
			//{
			//	return new nilnul.num.real_.Quotient(1);
			//}

			// such as -3/4 so the radic cannot be 0 or neg in this case
			// but for -3/5 the radic can be negative, but not nil.
			return op_.unary_._RootX.RetRealI(
				op_.unary_._IndexX.RetRealI(
					real
					,
					sup.numerator
				)       // if the denominator is even, exception is thrown; for odd denominator, the index can have both num and denominator muliplied by two and hence exception.
				, sup.denominator1
			);
		}

		static public nilnul.num.RealI _RealI_assumeSupNotTrivia(nilnul.num.RealI real, nilnul.num.Quotient1 sup)
		{

			if (nilnul.num.real.be_.Quotient.Singleton.be(real))
			{
				return _RealI_assumeSupNotTrivia(real.current.lower.mark, sup);
			}
			return _RealI_baseUnsureQuotient_assumeSupNotTrivia(real, sup);

		}

		static public nilnul.num.RealI _RealI_assumeSupNotInteger(nilnul.num.RealI real, nilnul.num.Quotient1 sup)
		{
			if (sup.numerator == 1)
			{
				return op_.unary_._RootX.RetRealI(real, sup.denominator1);
			}
			return _RealI_assumeSupNotTrivia(real, sup);
		}


		static public nilnul.num.RealI RetRealI(nilnul.num.RealI real, nilnul.num.Quotient1 sup)
		{
			if (sup.denominator1 == 1)
			{
				return _IndexX.RetRealI(real, sup.numerator);
			}
			return _RealI_assumeSupNotInteger(real, sup);
		}
	}


	public class Pow :
		nilnul.obj.Box<nilnul.num.Quotient1>
		,
		PowI, _unary_.RetRealOnRealI
	{
		public Pow(Quotient1 val) : base(val)
		{
			///for integer using pow_.Integer, it's indexer
			///		which in turn may use poly
		}

		public RealI op(RealI par)
		{
			return _PowX.RetRealI(par, boxed);
		}

		public Real op_retReal(RealI par)
		{
			return UnaryX.RetReal(this, par);
		}
	}
}
