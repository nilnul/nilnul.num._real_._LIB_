using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.co.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		Ee4dbl
		where TVow : nilnul.obj.VowI2<(double, double)>, new()
	{
		public VowNeo4Dbl((double, double) val)
			:
			base(
				val
				,
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
			)
		{
		}
	}
}
