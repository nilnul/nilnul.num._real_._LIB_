using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.RealI;  //.RealI_posConverge2NonEmpty;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.stream_.slider.subsume_._exp
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///	not user whether the speed of converging is faster than op_.unary_._exp.ret_.BoundOped, as latter has to compute the boundOped every time, and this stream can reuse each addend's state of already converged.
	///		because each temr is real, and when  the residue is used to estimate discrepany, the discrepany has to be appropriate again for each term's convergence. So this might not work
	/// </remarks>

	public class Slider
		:
		nilnul.num.real.stream_.slider.op_.unary_._scale.Of
		,
		real.stream_.SliderI
	{


		public Slider(R index) : base(
			new nilnul.num.quotient.stream_.slider_.factorial.Inverse()		//1/0!,1/1,1/2
			,
			new constant.Prod(index)		//1,x,x^2,x^3
		)
		{

		}

		
	}
}

