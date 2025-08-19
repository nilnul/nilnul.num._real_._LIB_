using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_blank;

namespace nilnul.num.real.duo.op
{
	[Obsolete()]
	public class Add
	{
		public class Call
			:nilnul.obj.duo._call.Args_bothSameType<R>
		{
			public Call(R arg,R arg1):base(arg,arg1)
			{

			}

			public num._real.limit.List knownCauchies() {

				var r = new num._real.limit.List();

				foreach (var item in arg.KnowCauchies() )
				{
					foreach (var item2 in arg1.KnowCauchies())
					{
						r.Add( new num._real.limit.duo.op.Add.Call(item,item2));

					}
				}
				return r;

				throw new NotImplementedException(
					"the cartesian product of (the cauchies of arg, the cauchies of arg1), then sum the element (the duo of cauchies) to get a cauchy; all the cauchies resulted are returned."
				);
			}
		}
	}
}
