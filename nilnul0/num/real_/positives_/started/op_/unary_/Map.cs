using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positives_.started.op_.unary_
{
	public class MapDbl : nilnul.objs_.started.op_.unary_.Map<PositiveDbl>
	{
		public MapDbl(Func<PositiveDbl, PositiveDbl> val) : base(val)
		{
		}

		public MapDbl(Func<double,double> v):this(
			new Func<PositiveDbl, PositiveDbl>(
				x=>new PositiveDbl( v(x.ee) )
			)
		)
		{

		}
	}
}
