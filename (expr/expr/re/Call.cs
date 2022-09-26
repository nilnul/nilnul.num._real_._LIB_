using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.re
{
	public class Call
		: nilnul.num.real.expr.Co
		,
		_call_.ReI

	{

		public Call(real.ReI re, Tuple<ExprI, ExprI> tuple) : base(tuple)
		{
			_re = re;
		}

		public Call(real.ReI re, (ExprI, ExprI) valTuple) : base(valTuple)
		{
			_re = re;
		}

		public Call(real.ReI re,ExprI item1, ExprI item2) : base(item1, item2)
		{
			_re = re;
		}

		real.ReI _re;
		public real.ReI re => _re;
	}
}
