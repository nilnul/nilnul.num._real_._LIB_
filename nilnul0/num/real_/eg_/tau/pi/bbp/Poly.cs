using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.real._real.converge.eg.pi.bbp
{
	/// <summary>
	/// http://en.wikipedia.org/wiki/Bailey%E2%80%93Borwein%E2%80%93Plouffe_formula
	/// The Bailey–Borwein–Plouffe formula (BBP formula) is a spigot algorithm for computing the nth binary digit of pi (symbol: π) using base 16 math. 
	/// </summary>
	public partial class Poly 
	{

		/// <summary>
		/// the transformed numerator from BBP
		/// </summary>
		/// <param name="k"></param>
		/// <returns></returns>
		static public BigInteger NumeratorFunc(BigInteger k) {
			return 120 * nilnul.num.op.Square.Eval(k) + 151 * k + 47;
		}
		/// <summary>
		/// the transformed Denominator of BBP
		/// </summary>
		/// <param name="k"></param>
		/// <returns></returns>

		static public BigInteger DenominatorExpr(BigInteger k) {
			return 512 * nilnul.num.op.Pow.Do_nonNeg_nonNeg(k, 4) + 1024 * nilnul.num.op.Pow.Do_nonNeg_nonNeg(k, 3) + 712 * nilnul.num.op.Square.Eval(k) + 194 * k + 15;
		}



		
	}
}
