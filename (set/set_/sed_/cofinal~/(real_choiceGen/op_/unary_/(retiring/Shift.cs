using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num._real.approach;
using nilnul.num.real.all;
using nilnul.num.real_;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.op_
{
	[Obsolete()]
	public class Shift : FroApproachOp
	{
		public Shift(Q shift) : base(
			new nilnul.num._real.approach.op_.Shift(shift)
			)
		{
		}
	}
}