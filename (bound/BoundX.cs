using nilnul.num.real._bound;
using nilnul.num.real._bound.lowerUpper.be_.dwelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.num.real
{
	static public class BoundX
		
	{
		
		public static RealI Diameter(this BoundI bound) => bound.upper.mark.ToReal() - bound.lower.mark;

		public static nilnul.num.quotient.bound_.Closed Outer(this BoundI bound ) {
			return new quotient.bound_.Closed(
				bound.lower.mark.current.lower.mark
				,
				bound.upper.mark.current.upper.mark
			);
		}


	}


}
