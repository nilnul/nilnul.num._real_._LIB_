using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.xt.fn.src_.break_.conflu_
{
	/// <see cref="src_.contig_.IDiscontinuous"/>
	/// <summary>
	/// when the confluent is <see cref="src_.conflu_.IInfinite"/>, the src is a break point even when the tgt is infinity, as no matter how closer a point on one side is, the different of tgt cannot be small enough (it's still infinity).
	/// </summary>
    public interface IInfinite:IConfluent,src_.conflu_.IInfinite
    {
    }

}
