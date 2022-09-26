using nilnul.num.real.double_.ext.bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.interval.op
{
	public class Intersect
	{
		static public Couple Eval(Interval3 a, Interval3 b) {
			return  double_.ext.bound.couple.op.Intersect.Eval(a.val, b.val);
		}

		static public bool Joint(Interval3 a, Interval3 b) {
			return ext.bound.couple.be.Has.Eval( Eval(a, b));
		}
		static public bool DisJoint(Interval3 a, Interval3 b) {
			return !Joint(a, b);
		}
	}
}
