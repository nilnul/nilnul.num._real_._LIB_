using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.range
{
	/// <summary>
	/// 
	/// </summary>
	static public class _PointRel2RangeX
	{
		/// <summary>
		/// left, in, right
		/// </summary>
		/// <param name="range"></param>
		/// <param name="r"></param>
		/// <returns></returns>
		static public int Eval(nilnul.num.RealI r,nilnul.num.real.Bound range) {

			if (nilnul.num.real.border.comparer_.lower.Re.Singleton.lt(r,range.lower ) )
			{
				return -1;
			}
			else
			{
				if (nilnul.num.real.border.comparer_.upper.Decider.Singleton.gt(r, range.upper))
				{
					return 1;
				}
			}
			return 0;
		}
	


	}
}
