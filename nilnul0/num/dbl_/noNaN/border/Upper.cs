using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoNaN = nilnul.num.real.double_.b.NoNaN.Asserted;

namespace nilnul.num.real.double_.noNaN.border
{
	public class Upper

	{

		static public bool Contain(Border border, NoNaN noNaN) {

			return nilnul.comparer.border.Upper.Contain<NoNaN, Comparer, Border>(border, noNaN);
		}



	}
}
