using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt.fn.src_.break_
{
	/// <summary>
	/// if one side is approaching infinity, then it's definitely a breakpoint, as no matter what the val of that point is, we cannot find a neighborhood where the tgt is arbitrarily close the that val.
	/// </summary>
    public interface IInfinite:src_.IBreak
    {
    }


}
