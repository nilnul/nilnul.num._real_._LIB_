using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	static public class _PositiveX
	{
		static public nilnul.num.real.Bound Create(nilnul.num.real.Border real) {
			return new Bound( nilnul.num.real.Border.CreateOpen(0),   (real));
		}
		static public nilnul.num.real.Bound CreateClose(nilnul.num.RealI real) {
			return Create(    nilnul.num.real.Border.CreateClose(real));
		}

		static public nilnul.num.real.Bound CreateClose(int real) {
			return CreateClose(new nilnul.num.real_.Quotient(real) );
		}
	

		static public nilnul.num.real.Bound CreateOpen(nilnul.num.RealI real) {
			return Create(  nilnul.num.real.Border.CreateOpen(real));
		}


	}
}
