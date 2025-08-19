using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nilnul.num.real.str.scala_._DepartureX;//.Departure;

namespace nilnul.num.real.vec.co.theorem_.comp_
{
	/// <summary>
	/// The Cauchy–Schwarz inequality (also called Cauchy–Bunyakovsky–Schwarz inequality)
	/// </summary>
	static public class _CauchyBunyakovskySchwarzX
	{
		/*
		  |u+v| <= |u| + |v|
		 */


		static public bool _Pred_1equisize(
			IEnumerable<double> u
			,
			IEnumerable<double> v
		) {
			return
				Departure(
					vec.of_.binary_._AddX._Add_1equisize(u, v)
				)
				<=
				Departure(
					u
				)
				+
				Departure(v)
			;


		}
	}
}
