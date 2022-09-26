using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;

namespace nilnul.num.real_._positive
{
	[MayPerpetual]
	static public  class _Clamp_ofAssumePositiveX
	{
		/// <summary>
		/// half and halve, till ends met
		/// for an assumed positive real, converge it such that the lower bound is positibe
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 
		static public void Void(this R real) {


			while (real.current.lower.mark <= 0)
			{
				real.ClampHalf();

			}

		}

		static public void Clamp4LowerPositive_assumePositive(this R real) {

			MakeLowerNonneg_assumePositive(real);

			while (real.current.lower.mark == 0)
			{
				real.ClampHalf();

			}

		}

		static public void MakeLowerNonneg_assumePositive(this R real) {

			var lowerMark = real.current.lower.mark;

			while ( lowerMark< 0)
			{
				real.Clamp(
					-lowerMark/real.current.diameter1
				);

				lowerMark = real.current.lower.mark;

			}

		}


	}
}
