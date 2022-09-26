using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg
{
	public class CoDbl : nilnul.obj.Co<nilnul.num.real_.NonnegOfDoubleI>
	{
		public CoDbl(Tuple<NonnegOfDoubleI, NonnegOfDoubleI> tuple) : base(tuple)
		{
		}

		public CoDbl((NonnegOfDoubleI, NonnegOfDoubleI) valTuple) : base(valTuple)
		{
		}

		public CoDbl(NonnegOfDoubleI item1, NonnegOfDoubleI item2) : base(item1, item2)
		{
		}

		public CoDbl(NonnegOfDouble item1, NonnegOfDouble item2) : base(item1, item2)
		{
		}

		public CoDbl(double x, double y):this( new NonnegOfDouble(x), new NonnegOfDouble(y))
		{

		}
		/// <summary>
		/// last - first
		/// </summary>
		/// <returns></returns>
		public double displace() {
			return component1.realee.ee - component.realee;
		}

		/// <summary>
		/// first - last
		/// </summary>
		/// <returns></returns>
		public double descending() {
			return component.realee.ee - component1.realee;
		}

		static public CoDbl CreateByAbs(
			double x, double y
		) {
			return new CoDbl(
				NonnegOfDouble.CreateByAbs(x)
				,
				NonnegOfDouble.CreateByAbs(y)
				
			);
		}
	}
}
