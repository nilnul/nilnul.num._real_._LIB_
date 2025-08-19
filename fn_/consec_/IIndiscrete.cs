using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.consec_
{
	/// <summary>
	/// it's not <see cref="IEnumerable"/>.
	/// according to "continuum hypothesis", it's continuum, that is there is at least one <see cref="interval_.ISpanned"/>
	/// </summary>
	/// alias:
	///		indiscrete
	///			,where "in" is similar as the "in" in "infinite"
	///		unEnumerable
	///		undiscrete
    public interface IIndiscrete:IConsecutive
    {
    }

}
