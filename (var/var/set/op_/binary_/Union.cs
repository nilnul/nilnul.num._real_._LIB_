using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var.set.op_.binary_
{
	static public class _UnionX
	{
		static public nilnul.num.real.var.Set Union(
			nilnul.num.real.var.Set set
			,
			nilnul.num.real.var.Set set1

		) {
			var r = new nilnul.num.real.var.Set();
			r.UnionWith(
					set

				);
			r.UnionWith(
					set1
			);
			return r;
		}
	}
}
