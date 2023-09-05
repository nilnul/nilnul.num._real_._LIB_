using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream
{
	public class Stock
		: nilnul.num.real.stream.Stock< nilnul.num.real.StreamI>
	{
		public Stock(nilnul.num.real.StreamI val) : base(val)
		{
		}
	}
}
