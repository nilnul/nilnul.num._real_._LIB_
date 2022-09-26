using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.real
{
	public class SortedSet
	{

		/// <summary>
		/// right continuous like the Cdf of probability distribution.
		/// </summary>
		/// <param name="_sorted"></param>
		/// <param name="reading"></param>
		/// <returns></returns>
		static public int _Rank_retInt(decimal[] _sorted, decimal reading) {

			var i = 0;
			for (; i < _sorted.Length; i++)
			{
				if (_sorted[i]>=reading)
				{
					break;

				}
			}
			return i;

		}


	}
}
