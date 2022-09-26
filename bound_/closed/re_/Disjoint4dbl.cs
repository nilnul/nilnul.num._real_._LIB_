using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.re_
{
	/// <summary>
	/// share no point
	/// </summary>
	public class Disjoint4dbl
		:
		closed.Re4dblI
	{

		/// <summary>
		/// either a is totally lower, or totally upper
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(ClosedDbl a, ClosedDbl b)
		{
			return (a.avowed.upper.mark < b.avowed.lower.mark)
				|| (a.avowed.lower.mark > b.avowed.upper.mark)
			;
		}


		static public Disjoint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Disjoint4dbl>.Instance;
			}
		}

	}
}
