using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.co
{
	/// <summary>
	/// note alesce returns another vec, not a number/component;
	/// </summary>
	/// vs:
	///		scala, which returns a scalar, but <see cref="nilnul.obj.str.IScala"/> returns the element, in this case, it's a vec
    public interface IAlesce
		:nilnul.obj.co.IAlesce<IReal>
    {
    }


  


}
