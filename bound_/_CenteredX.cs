using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	static public class _CenteredX
	{
		static public nilnul.num.real.Bound CenterNilOpen(nilnul.num.real_.PositiveI x ) {
			return Bound.CreateOpen(
				-x.ToReal()
				,
				x
			);
		}

		public static Bound CenterNilOpen_ofRadius(Real radius)
		{
			return CenterNilOpen(
				new nilnul.num.real_.Positive(radius)
			);
		}

		static public nilnul.num.real.Bound CenterNilClose(nilnul.num.real_.NonnegI x ) {
			return Bound.CreateClose(
				-x.ToReal()
				,
				x
			);
		}

		static public nilnul.num.real.Bound Close_ofCenterRadius(nilnul.num.RealI center, nilnul.num.real_.NonnegI x ) {
			var classed = x.ToReal();
			return Bound.CreateClose(
				center-classed
				,
				center + classed
			);
		}

		static public nilnul.num.real.Bound Open_ofCenterRadius(nilnul.num.RealI center, nilnul.num.real_.PositiveI x ) {
			var classed = x.ToReal();
			return Bound.CreateClose(
				center-classed
				,
				center + classed
			);
		}

		static public nilnul.num.real.Bound Clopen_ofCenterRadius(nilnul.num.RealI center, nilnul.num.real_.PositiveI x ) {
			var classed = x.ToReal();
			return Bound.CreateClopen(
				center-classed
				,
				center + classed
			);
		}


		static public nilnul.num.real.Bound OpenClose_ofCenterRadius(nilnul.num.RealI center, nilnul.num.real_.PositiveI x ) {
			var classed = x.ToReal();
			return Bound.CreateOpenClose(
				center-classed
				,
				center + classed
			);
		}



	}
}
