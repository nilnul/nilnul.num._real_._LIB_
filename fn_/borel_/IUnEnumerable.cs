using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_.borel_
{
	/// <summary>
	/// it's not <see cref="IEnumerable"/>.
	/// according to "continuum hypothesis", it's continuum, that is there is at least one <see cref="interval_.ISpanned"/>
	/// </summary>
    public interface IUnEnumerable:IBorel
    {
    }

}
