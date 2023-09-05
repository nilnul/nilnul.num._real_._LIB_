using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.duo_.quotient.be_.approx_.best_
{
	/// pi.math.cornell.edu/~gautam/ContinuedFractions.pdf
	/// p20, definition 4.13;
	/// <summary>
	/// A fraction p/q is a best approximation of the second kind to a real	number t if for every fraction a/b with denominator less than or equal to q, we have |qt − p| <|bt − a|.
	/// imaging two lines: y=tx
	///		when x=q, we got qt, and qt is distant from p, but for any x=b, the point at the line is bt, which is more distant from even a nearby lattice point.
	///		in other words, this, (q,p), is the lattice point that is vertically the nearest to the line for any points nearer to the origin.
	/// </summary>
	/// <remarks>
	/// also known as:
	///		a best approximation of the second kind;
	/// 
	/// this implies <see cref="BestApprox"/>, as we require q, and b to be positive;
	/// </remarks>
	/// alias:
	///		lattice
	///		asymptonic
	///		
	internal class ILattice
	{
	}
}
