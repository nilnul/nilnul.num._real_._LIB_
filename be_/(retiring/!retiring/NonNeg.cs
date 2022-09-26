using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num._real.approach.generator.CofinalI;

namespace nilnul.num.real.be
{
	public partial class NonNeg
	{

		/// <summary>
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// <exception cref="">may never return; this is an exception.</exception>
		static public bool Eval(R real)
		{

			var approach = real.choice.generate();

			var span = approach.bound;



			var precision = new rational.Rational_InheritFraction2(1);

			var real2rational = real.choice.generate();
			real2rational.clamp(precision);

				
				var .clamp(precision);
			while (true)
			{
				if (real2rational > precision)
				{
					return true;

				}
				if (real2rational < -precision)
				{
					return false;

				}

				precision /= 2;

				real2rational = real.ToRational(precision);

			}



		}


		static public bool Eval(RealI_posConverge2NonEmpty x) {

			if (Zero.Eval(x))
			{
				return false;
				
			}

			return x.interval.midpoint > 0;
			
		}

		public class Be
			:nilnul.bit.Be<RealI_posConverge2NonEmpty>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Asserted:
			nilnul.bit.be.Asserted<RealI_posConverge2NonEmpty,Be>
		{
			public Asserted(RealI_posConverge2NonEmpty x)
				:base(x)
			{

			}

		}
	}
}
