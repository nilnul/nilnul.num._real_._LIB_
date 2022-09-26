using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary.recur_
{
	public class OpDefault<TOp>
		:
		Recur4dbl
		where TOp : real.op_.Unary4dblI, new()
	{
		public OpDefault(double initial0) : base(initial0, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance)
		{
		}
	}
}
