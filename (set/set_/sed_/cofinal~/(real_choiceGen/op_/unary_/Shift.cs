using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num._real.approach;
using nilnul.num.real.all;
using nilnul.num.real_;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI3;

namespace nilnul.num.real.op_.unary_
{
	public class Shift : 
		nilnul.obj.Box<Q1>
		,
		UnaryI1
	{
		public Shift(Q1 shift) : base(
			shift
		)
		{
		}

		public num.RealI3 op(num.RealI3 par)
		{
			return new _shift.Ret(this.boxed, par);
		}
	}
}