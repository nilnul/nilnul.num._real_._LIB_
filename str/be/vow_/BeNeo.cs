using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be.vow_
{
	public class BeNeo<TBe>
		:
		real.str.be.Vow4dbl
		where TBe: obj.BeI1<IEnumerable<double>>,new()
	{
		public BeNeo() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}
	}
}
