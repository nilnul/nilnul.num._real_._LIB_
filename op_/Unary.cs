using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	public class Unary
		:
		nilnul.obj.op_.Unary<num.RealI>
		,
		nilnul.num.real.op_.UnaryI

	{
		public Unary(Func<RealI, RealI> val) : base(val)
		{
		}
	}



}
