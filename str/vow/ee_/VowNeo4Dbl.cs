using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.vow.ee_
{
	public class VowNeo4Dbl<TVow>
		:
		Ee4dbl
		where TVow: VowI2<IEnumerable<double>>,new()
	{
		public VowNeo4Dbl(IEnumerable<double> val) : base(val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

		)
		{
		}
	}
}
