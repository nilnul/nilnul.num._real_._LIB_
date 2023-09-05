using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.Quotient1;//.Rational_InheritFraction2;
using R = nilnul.num.RealI;  //.RealI_posConverge2NonEmpty;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.stream_.slider.subsume_
{
	/// <summary>
	/// using McLaurin Series
	/// </summary>
	/// <remarks>
	///	not user whether the speed of converging is faster than op_.unary_._exp.ret_.BoundOped, as latter has to compute the boundOped every time, and this stream can reuse each addend's state of already converged.
	///		because each temr is real, and when  the residue is used to estimate discrepany, the discrepany has to be appropriate again for each term's convergence. So this might not work
	/// </remarks>

	public class Exp
		:
		nilnul.num.real.stream_.slider.Subsume_opDefault_add


	{
		public Exp(R index) : base(new _exp.Slider(index))
		{
		}
	}
}

