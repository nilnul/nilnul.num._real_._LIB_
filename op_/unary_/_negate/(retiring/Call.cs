using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI2;

namespace nilnul.num._real.approach.op_._negate
{
	

		public class Call
			: Arg
			,
			ApproachI1

		{
			public Call(ApproachI1 arg) : base(arg)
			{

			}

			public Nonempty.En bound
			{
				get
				{
					return nilnul.num.quotient.range.op_._negate.Extensions.Negate(arg.bound);

					throw new NotImplementedException();
				}
			}

			public void clamp(Positive1.En diameter)
			{
				 arg.clamp(diameter);
				return;
				throw new NotImplementedException();
			}
		
	}

	public static class CallX
	{
		static public ApproachI1 Negate(this ApproachI1 x) {
			return new Call(x);
		}

	}
}
