using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn.src.be_._contin.semi_
{
	/// <summary>
	/// given a src: a
	/// , the function is defined at the interval of (a-delta, a], where delta is a positive real that is arbitrarily small.
	/// , the function approaches  to f(a) as x -> a-, that x approaches to x from lower/left part;
	/// </summary>
    public interface ILeftContinuous
		:_contig.semi_.ILeftLimitable /// moreover, the tgt of the point is that limit
    {
    }

}
