using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;
using R = System.Double;

namespace nilnul.num.real.bi.cumula_
{
	public class OpDefault8dbl<TOp>
		:
		nilnul.obj.bi.cumula_.OpDefault<double,  TOp>
		,bi.Cumula8dblI

		where TOp : nilnul.num.real.Bi8dblI, new()
	{
		public OpDefault8dbl(R initial) : base(initial)
		{
		}

	}
	


}
