using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.started_.distinct
{
	static public class _MaxX
	{
		static public int _Index_ofAssumeStartedDistance(IEnumerable<nilnul.num.RealI> _reals__startedDistinct) {
			var r = 0;
			for (int i = 1; i < _reals__startedDistinct.Count(); i++)
			{
				if (
					real.re_.Gt.Lazy.re(
						_reals__startedDistinct.ElementAt(i)
						,
						_reals__startedDistinct.ElementAt(r)
					)
				)
				{
					r = i;
				}
			}

			return r;
		}
	}
}
