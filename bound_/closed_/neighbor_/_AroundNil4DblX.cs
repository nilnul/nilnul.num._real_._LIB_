using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_.centered_
{
	static public class _AroundNil4DblX
	{


		

		static public nilnul.num.real.bound_.ClosedDbl Closed(nilnul.num.real_.NonnegOfDoubleI x ) {
			return new ClosedDbl(
				-x.realee
				,
				x.realee
			);
		}

		static public nilnul.num.real.bound_.ClosedDbl Closed(nilnul.num.real_.NonnegOfDouble x ) {
			return new ClosedDbl(
				-x.realee
				,
				x.realee
			);
		}

		static public nilnul.num.real.bound_.ClosedDbl Closed(double x ) {
			return new ClosedDbl(
				-x
				,
				x
			);
		}

		static public nilnul.num.real.bound_.ClosedDbl Closed_absOf(double x ) {
			return Closed(Math.Abs(x));
		}








	}
}
