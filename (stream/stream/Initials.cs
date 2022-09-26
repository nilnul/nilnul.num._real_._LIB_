using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream
{
	public class Stock<TStream>
		: nilnul.obj.stream.Stock<nilnul.num.RealI, TStream>
		where TStream: nilnul.obj.StreamI2<RealI>
	{
		public Stock(TStream val) : base(val)
		{
		}
	}
}
