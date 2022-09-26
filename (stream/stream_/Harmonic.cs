using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.num.real.sequence
{
    public class Harmonic
    {
		static public Rational_InheritFraction Eval(nilnul.num.natural.PositiveNatural_inheritNatural2 n) {

			var r = R.NewZero;

			for (BigInteger i = 1; i <= n.val; i++)
			{
				r +=new nilnul.num.rational.func.UnitFraction(i);
				
			}
			return r;
		
		}

		static public bool IsConvergent {
			get {
				return false;
			}
		}
    }
}
