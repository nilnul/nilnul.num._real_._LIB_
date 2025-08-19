using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.analytic_
{
	/// some power series converges to a function that we give a name, such as:
	///		e^x
	///		ln(x)
	///		,or any fn that can be derived from thses functions.
	///	; note all power series have a name. we generally require here the power series when represented by a function is continuous consistently.
	///
	/// <summary>
	/// if the form is open, then we can only apply general power series processing method, and for arbitrary fn, to transfer that into power series is not an enumerable (might be uncountable, as every real number is, for eg in the form of positional notation, a power series form ) algorithm.
	/// So we need to keep the form closed (that is: keep the collective finite) such that correspondingly the designed algorithm can be finite, tackling them in a paticuarized way.
	/// ;
	/// But which <see cref="num.real.IFn"/> shall be in the closed form is not consent.
	/// Generally:
	/// 
	/// e^x
	///		,and its inverse:
	///			 ln(x)
	/// trigonometric
	///		and their inverse
	///	hyperbblic, and their inverse.
	///
	///  excluding:
	///		recursive numerical method.
	/// </summary>
	/// <remarks>
	/// ; a prior set of functions, and the composition of these funcs, and the inverse of these funcs.
	/// the used funcs include:
	///		 ,including <see cref="IRadicandal"/>
	///		 , e^x, where x, unlike in <see cref="IRadicandal"/> can be irrational
	///				,note trigonometric for complex number is related to e^x.
	///				
	/// 
	/// </remarks>
	/// 
	/// alias:
	///		cloform
	///		algebraic
	///		complex
	///		planar
	///		cartesian
	///		radiant
	///		locus
	///		well-established
	///		power
	///		hyper operation, such as Knuth operator
	///
	/// vs:
	///		geometrical curve/locus
	///		complex func
	///		
	internal class IClosedForm
	{
	}


}
