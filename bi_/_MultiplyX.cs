using System.Runtime.CompilerServices;

using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.bi_
{
	static public class _MultiplyX
	{
		public const char SIGN = '*';
		/// <summary>
		/// name each argument
		/// </summary>
		/// <param name="multiplier"></param>
		/// <param name="multiplicand"></param>
		/// <returns>
		/// difference
		/// </returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Multiply(
			double multiplier
			,
			double multiplicand
		) {
			return multiplier * multiplicand;
		}

		static public R Multiply(R a, R b)
		{
			if (object.ReferenceEquals(a, b))       //to maximize the reuse of the converging process
			{
				return nilnul.num.real.op_._SquareX.Op(a);
			}

			if (nilnul.num.real.be_.Quotient.Singleton.be(a))
			{
				return nilnul.num.real.op_._ScaleX.Op(a.current.begin, b);
			}
			if (nilnul.num.real.be_.Quotient.Singleton.be(b))
			{
				return nilnul.num.real.op_._ScaleX.Op(b.current.begin, a);

			}

			//if (object.ReferenceEquals(a,b) )		//to maximize the reuse of the converging process
			//{
			//	return nilnul.num.real.op_.unary_._SquareX.Op_assumeNotQuotient(a);
			//}
			return new _mul.Ret(a, b);
			//throw new NotImplementedException();
		}





	}


}
