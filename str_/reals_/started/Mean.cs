using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str_.started
{
	/// <summary>
	/// note: 1,1,2,... so this is better treated as a str rather than a set.
	/// </summary>
	/// <remarks>
	///		Mean is put into set, not str, thus we don't need to consider the order when doing recursions, iterations ,or secting(aka partitioning).
	///		This is put under "to_", 'cuz this is a degression operation from a set to a number.
	/// </remarks>
	static public class _MeanX
	{
		static public double Avg(  params double[] _seed) {

			return _seed.Average();

		}

		static public R _Avg(this IEnumerable<R> _seededSet) {
			return 
				nilnul.num.real.op_.unary_._ScaleX.Op(
					nilnul.num.real.str._SumX.Sum_bisect(_seededSet), 
				
					nilnul.num.QuotientX.Inverse(
						_seededSet.Count()
					)
				); 

			//return 
			//	nilnul.num.real.co_.divisible.op_.Div.Singleton.eval(
			//	nilnul.num.real.set.to_._x._SumX.Sum_bisect(_seededSet), _seededSet.Count()
			//	); 


		}
	}
}
