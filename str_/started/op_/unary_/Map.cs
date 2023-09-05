using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals_.started.op_.unary_
{
	public interface MapDblI :nilnul.objs_.started.op_.unary_.MapI<double>
	{

	}

	public class MapDbl
		:
		nilnul.objs_.started.op_.unary_.Map<double>
		,
		MapDblI
	{
		public MapDbl(Func<double, double> val) : base(val)
		{
		}
	}
}
