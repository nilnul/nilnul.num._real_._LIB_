using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound
{
	public class Couple
		:nilnul.order.bound.Pair_TBound<Bound>
	{
		public Couple(Bound lower, Bound upper)
			:base(lower, upper)
		{

		}

		public Couple( nilnul.order.bound.Pair_TBound<Bound> bounded)
			:this(bounded.lower,bounded.upper)
		{


		}
		public bool contains(_ext.ExtI ext) {

			return
				nilnul.order.bound.duo.LowerX.Contains(this.lower, ext, double_.ext.Ord.Singleton)
				&&
				nilnul.order.bound.duo.UpperX.Contains(this.upper, ext, double_.ext.Ord.Singleton)
			;

		}
		public bool contains(double x) {

			return contains(new _ext.Literal(x) as _ext.ExtI);
				
		}

	
	}
}
