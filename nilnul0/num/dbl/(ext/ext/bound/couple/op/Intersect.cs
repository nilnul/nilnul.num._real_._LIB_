using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound.couple.op
{
	public class Intersect
	{
		static public Couple Eval(Couple x, Couple y) {
			return new Couple(  nilnul.order.comparer.bounded.op.Intersect_comparerDefault<double_._ext.ExtI, double_.ext.Ord, ext.Bound>.Eval(x, y));
		}
	}
}
