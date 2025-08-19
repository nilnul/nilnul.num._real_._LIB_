using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn.src.be_._contig.semi_
{
	/// <summary>
	/// given a src: a
	/// , the function is defined at the interval of (a-delta, a], where delta is a positive real that is arbitrarily small.
	/// , the function approaches  to f(a) as x -> a-, that x approaches to x from lower/left part;
	/// </summary>
	/// alias:
	///		leftLimitable
	///		leftApproachable
	///		
	/// vs:
	///		<see cref="_contin.semi_.ILeftContinuous"/> where the tgt of the point is the same as the left limit
    public interface ILeftLimitable
    {
    }

}
