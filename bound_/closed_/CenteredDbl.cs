using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_
{
	static public class _CenteredDblX
	{


		

		static public nilnul.num.real.bound_.ClosedDbl CenterNilClose(nilnul.num.real_.NonnegOfDoubleI x ) {
			return new ClosedDbl(
				-x.realee
				,
				x.realee
			);
		}

		static public nilnul.num.real.bound_.ClosedDbl Close_ofCenterRadius(double center, nilnul.num.real_.NonnegOfDoubleI x ) {
			var classed = x.realee;
			return new ClosedDbl(
				center-classed
				,
				center + classed
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="center"></param>
		/// <param name="reach">nonneg while radius is positve</param>
		/// <returns></returns>
		static public (double,double) Marks_ofCenterReach(double center, nilnul.num.real_.NonnegOfDoubleI reach ) {
			var classed = reach.realee;
			return (
				center-classed
				,
				center + classed
			);
		}

		static public (double,double) Marks_ofCenterReach(double center, real_.NonnegOfDouble reach ) {
			return Marks_ofCenterReach(
				center,(NonnegOfDoubleI)(reach)
			);
		}
		static public (double,double) Marks_ofCenterReach(double center, double reach ) {
			return Marks_ofCenterReach(
				center,new real_.NonnegOfDouble(reach)
			);
		}

		static public nilnul.num.real.bound_.ClosedDbl Close_ofCenterRadius(double center, nilnul.num.real_.NonnegOfDouble x ) {
			
			return Close_ofCenterRadius(center, (real_.NonnegOfDoubleI)x);
		}

		static public nilnul.num.real.bound_.ClosedDbl Close_ofCenterRadius(double center, double x ) {
			return Close_ofCenterRadius(
				center,
				new nilnul.num.real_.NonnegOfDouble(Math.Abs(x))
			);
		}







	}
}
