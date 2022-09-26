using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	[Obsolete(nameof(real.all.X))]
	static public class RealIX
	{
		[Obsolete(nameof(_Clamp_unitFracDenominator))]
		static public Q _Clamp(this R r, int unitFracDen_positive ) {
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(unitFracDen_positive)	
				)
			);
			return x.bound.midPoint;


		}

		static public Q _Clamp_unitFracDenominator(this R r, int unitFracDen_positive ) {
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(unitFracDen_positive)	
				)
			);
			return x.bound.midPoint;


		}

		static public Q _Clamp_unitFracDenominator(this R r, BigInteger unitFracDen_positive ) {
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit(unitFracDen_positive)	
				)
			);
			return x.bound.midPoint;


		}



		static public Q _ClampAsQ2DigitsAftDot(this R r, uint digitsAftDot ) {
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit( 
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10,  digitsAftDot)
					
					)	
				)
			);
			return x.bound.midPoint;


		}

		static public num.quotient.radix.Dec _Clamp2Dec_DigitsAftDot(this R r, uint digitsAftDot ) {
			var x = r.choice.generate();
			x.clamp(
				new quotient.be_.Positive1.En(
					Q._CreateUnit( 
						nilnul.num.duo.op_.Pow.Do_basePlural_indexNonNeg(10,  digitsAftDot)
					
					)	
				)
			);

			return nilnul.num.quotient.radix.Dec.FroQuotient( x.bound.midPoint,digitsAftDot);


		}


		static public num.quotient.radix.recur.Dec _Clamp2DecRecur_DigitsAftDot(this R r, uint digitsAftDot ) {
			var x = r.choice.generate();


			return nilnul.num.quotient.radix.recur.Dec._FroQuotient(
				
				_Clamp_unitFracDenominator(
					r,
					nilnul.num.duo.op_.Pow._Eval_basePlural_indexNonNeg(10,  digitsAftDot)

				),
				
				digitsAftDot
				
				);


		}




	}
}
