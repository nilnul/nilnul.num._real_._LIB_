using nilnul.bit.combine_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr
{
	public class Co
		: nilnul.obj.Co<
			nilnul.num.real.ExprI
		>
	{
		public Co(Tuple<ExprI, ExprI> tuple) : base(tuple)
		{
		}

		public Co((ExprI, ExprI) valTuple) : base(valTuple)
		{
		}

		public Co(ExprI item1, ExprI item2) : base(item1, item2)
		{
		}
	}
}
