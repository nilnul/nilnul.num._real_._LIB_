using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.convergent.deviation_
{

	internal class _ByLowersX
	{
		///pi.math.cornell.edu/~gautam/ContinuedFractions.pdf
		///p17;
		///theorem4.8;
		///
		/// <summary>
		/// the tail is irrational
		/// </summary>
		/// <param name="index">m</param>
		/// <param name="lowerAtIndex"></param>
		/// <param name="denomsGtIndex"> q'[m+1], <see cref="num.quotient.stream_.fractile._convergent._Lowers"/></param>
		/// <returns>
		/// q[-2] =1
		/// q[-1] = 0
		/// q[0]=1
		/// so when <paramref name="index"/> is 0, the returned is: 1/ tail[1...]
		/// 
		/// </returns>
		/// the returned, when absed, would be lt:  1/(q[m]*q[m+1]); that means deviation is lt that.
		/// moreover, according to <see cref=""/>
		static public Real _ByLowers_0index(BigInteger index, DenomNonnil lowerAtIndex, Real denomsGtIndex)
		{
			return nilnul.num.integer.of_.unary_._NegOneIndicedX.NegOneIndicedAsInt(index) / (lowerAtIndex * denomsGtIndex);
		}
	}
}
