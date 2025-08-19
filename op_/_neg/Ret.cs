using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using R = nilnul.num.RealI_onQuotient;
using nilnul.num.quotient;

namespace nilnul.num.real.op_._neg
{


	public class Ret
		: calc_._unary.Arg
		,
		R

	{
		public Ret(R arg) : base(arg)
		{

		}


		public Clamp current =>(-arg.current.end, -arg.current.begin );
		public void cinch(quotient_.denomNonnil_.Positive diameter)
		{

			arg.cinch(diameter);
			return;
		}

	}

	
}
