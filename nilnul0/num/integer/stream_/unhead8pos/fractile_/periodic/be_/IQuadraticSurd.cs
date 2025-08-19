using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.be_
{
	/// <summary>
	/// A periodic continued fraction is a quadratic surd, i.e. an irrational root of a	quadratic equation with integral coefficients.
	/// </summary>
	/// <remarks>
	///The continued fraction which represents a quadratic surd is periodic.
	/// </remarks>
	internal class IQuadraticSurd
	{
		/// x^2 - px -1 = 0
		/// =>
		/// x^2 = 1+px
		/// = per x >
		///	x = p +1/x
		///		= p + 1/ (p+1/x)
		///		= p+ 1/ (p + 1/ (p+x))
		///		= ...
		///
		/// so
		///		5+ 1/(5+ 1/ (5+ ...)) =y
		///		then 5 + 1/y =y
		///		=> y^2 -5y +1 =0
		///	;
		///
		/// 



	}
}
