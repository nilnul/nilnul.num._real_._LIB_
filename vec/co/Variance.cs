using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vector.duo
{
	public class Variance
	{
		static public decimal _Eval_vowSameDim(
			decimal[] _x
			,
			decimal[] _y
			
		) {

			return nilnul.num.real.accumulate_.SquareSum.Eval(  vector.combine_._MinusX._Eval(_x, _y)
			);

		}
	}
}
