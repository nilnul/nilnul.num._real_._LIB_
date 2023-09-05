using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str_
{
	static public class _StartedX
	{
		static public R _Max(this IEnumerable<R> _started) {
			return nilnul.str_.started.X._MaxBy_byAggregate(_started, nilnul.num.real.Comparer.Singleton);

		}

		static public R _Min(this IEnumerable<R> _started) {

			return nilnul.str_.started.X._MinBy_byAggregate(_started, nilnul.num.real.Comparer.Singleton);
		}
		static public R _MidRange( this IEnumerable<R> _started) {

			return
				nilnul.num.real.co_.divisible._DivX.Halve(
					nilnul.num.real.op_.binary_.Minus.Singleton.op(_started.Max(), _started.Min())
				)
			;

		}
	}
}
