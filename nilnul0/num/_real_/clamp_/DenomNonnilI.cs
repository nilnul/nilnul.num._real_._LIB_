using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real_.clamp_
{
	/*bound merge border will not need to squeeze again*/

	/// <summary>
	/// predicate the diameter needed, and clamp only once to get the desired result, as by looping it would be very time-consuming.
	/// squeeze from an approach to appraoch to a limit.
	/// </summary>
	public interface DenomNonnilI:
		//nilnul.num.quotient.bound_.closed.stream_.slider_.nested_._cauchy_.ClampI1
		nilnul.num.quotient_.denomNonnil.clasp.stream_.nested_._cauchy_.ClampI /*we leave this intentionally as ambiguous about whether the bound shall be closed, such that implementations can decide whether a non-closed bound can be returned and regarded (by converting) as closed. */
	//:
	//nilnul.num.quotient.stream_.bounded_._cauchy_.SqueezeI_boundDiameterLt	//make the boundDiameter strictly less than given para
	{
		/// <summary>
		/// bound.span less than (not equal, but strictly less than) the given
		/// </summary>
		/// <param name="boundStrictlyShorterThanThis">
		/// if the bound is close, we can set this para as the bound 's diameter, in order to squeeze it into a smaller one.
		/// the bound length (absolute value, not considering borderOpenOrClose) shall be less than (not equal to) the given parameter
		/// if the bound is not close, the bound's span can be less than or EQUAL TO given diameter; this is enough to guarantee that any single point's distance with the real is less than given diameter.
		/// if the bound is always closed for simplicity, then this parameter shall be strictly greater than bound's span.
		/// </param>
		//void squeeze(nilnul.num.quotient_.Positive1 boundStrictlyShorterThanThis);
	}

	

	


}
