using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	static public class _CenteredDblX
	{


		static public nilnul.num.real.BoundDbl CenterNilOpen(nilnul.num.real_.PositiveDblI x ) {
			return BoundDbl.CreateOpen(
				-x.dblen
				,
				x.dblen
			);
		}


		public static BoundDbl CenterNilOpen_ofRadius(double radius)
		{
			return CenterNilOpen(
				new nilnul.num.real_.PositiveDbl(radius)
			);
		}

		static public nilnul.num.real.BoundDbl CenterNilClose(nilnul.num.real_.NonnegOfDoubleI x ) {
			return BoundDbl.CreateClose(
				-x.realee
				,
				x.realee
			);
		}

		static public nilnul.num.real.BoundDbl Close_ofCenterRadius(double center, nilnul.num.real_.NonnegOfDoubleI x ) {
			var classed = x.realee;
			return BoundDbl.CreateClose(
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

		static public nilnul.num.real.BoundDbl Close_ofCenterRadius(double center, nilnul.num.real_.NonnegOfDouble x ) {
			
			return Close_ofCenterRadius(center, (real_.NonnegOfDoubleI)x);
		}

		static public nilnul.num.real.BoundDbl Close_ofCenterRadius(double center, double x ) {
			return Close_ofCenterRadius(
				center,
				new nilnul.num.real_.NonnegOfDouble(Math.Abs(x))
			);
		}

		static public nilnul.num.real.BoundDbl Open_ofCenterRadius(double center, nilnul.num.real_.PositiveDblI x ) {
			var classed = x.dblen;
			return BoundDbl.CreateClose(
				center-classed
				,
				center + classed
			);
		}


		static public nilnul.num.real.BoundDbl Open_ofCenterRadius(double center, double x ) {
			return OpenClose_ofCenterRadius(
				center,
				new nilnul.num.real_.PositiveDbl(Math.Abs(x))
			);
		}


		static public nilnul.num.real.BoundDbl Clopen_ofCenterRadius(double center, nilnul.num.real_.PositiveDblI x ) {
			var classed = x.dblen;
			return BoundDbl.CreateClopen(
				center-classed
				,
				center + classed
			);
		}


		static public nilnul.num.real.BoundDbl OpenClose_ofCenterRadius(double center, nilnul.num.real_.PositiveDblI x ) {
			var classed = x.dblen;
			return BoundDbl.CreateOpenClose(
				center-classed
				,
				center + classed
			);
		}



	}
}
