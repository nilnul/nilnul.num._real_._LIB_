using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.interval.duo
{
	public class MutualPosition
	{
		static public int Eval(Interval3 a,Interval3 b) {

			if (op.Intersect.Joint(a, b))
			{
				return 0;
			}
			if (ext.bound.CompareLower.Singleton.Compare(a.lower,b.lower) <0)
			{
				return -1;

			}

			return 1;

		}
	}
}
