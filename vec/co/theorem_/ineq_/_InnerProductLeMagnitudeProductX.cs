using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nilnul.num.real.str.scala_._DepartureX;//.Departure;

namespace nilnul.num.real.vec.co.theorem_.ineq_
{
	/// <summary>
	/// |u| |v| ge  u.v
	/// </summary>
	static public class _InnerProductLeMagnitudeProductX
	{
		/*
		  |u||v| >= |u.v|
		 */


		static public bool _Pred_1equisize(
			IEnumerable<double> u
			,
			IEnumerable<double> v
		) {
			return 
				Departure(
					u
				)
				*
				Departure(
					v
				)
				>=
				Math.Abs(
					real.vec.co._InnerProductX._InnerProduct_assumeEquisize(u,v)
				)
				
			;


		}
	}
}
