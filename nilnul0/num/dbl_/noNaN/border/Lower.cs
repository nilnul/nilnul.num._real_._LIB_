using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoNaN = nilnul.num.real.double_.b.NoNaN.Asserted;

namespace nilnul.num.real.double_.noNaN.border
{
	public class Lower

	{

		static public bool Contain(Border border, NoNaN noNaN) {

			return global::nilnul.comparer.border.Lower.Contain<NoNaN, Comparer, Border>(border, noNaN);
		}



	}
}
