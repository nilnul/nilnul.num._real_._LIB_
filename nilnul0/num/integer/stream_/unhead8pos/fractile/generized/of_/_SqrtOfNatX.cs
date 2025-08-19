using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.seq_.fractile.generized.of_
{
	/// <summary>
	/// for positive n,
	///		sqrt(n) = a+x
	///				
	///		x= (n-a^2)/(2a+x)
	///
	///  therefore, sqrt(n)
	///  =
	///  a+ ( n-a^2 )
	///		/
	///		( 2a+ (n-a^2)
	///				/ (2a+x )
	///		)
	///
	/// where a can be any positive number as long as n-a^2 is positive; but we need a to be bigger <see cref="num.quotient.stream_.nonhead8pos.fractile.be_.IConverging"/> such that numer is small enough, to make n-a^2 le 2a, n+1 le (a+1)^2, or n lt (a+1)^2, that is exactly how <see cref="nilnul.num.to_.sqrt._FloorX"/> gurantees;
	/// </summary>
	static public class _SqrtOfNatX
	{
		static public IEnumerable<BigInteger> _SqrtAsFractile_0nonneg(BigInteger n)
		{

			BigInteger sqrt =nilnul.num.to_.sqrt._FloorX._FloorOfSqrt_0nonneg(n);  //

			yield return sqrt;

			var sq = sqrt * sqrt;
			if (sq == n)
			{
				yield break;
			}

			var residue = n - sq;
			var sqrtDbl = 2 * sqrt;
			while (true)
			{
				yield return residue;
				yield return sqrtDbl;

			}
		}
	}
}
