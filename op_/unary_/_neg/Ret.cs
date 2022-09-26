using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;
using R = nilnul.num.RealI;
using A = nilnul.num.RealI;
using nilnul.num.quotient;

namespace nilnul.num.real.op_.unary_._neg
{


	public class Ret
		: _call_.Arg
		,
		R

	{
		public Ret(R arg) : base(arg)
		{

		}


		public nilnul.num.quotient.bound_.Closed current =>-arg.current;
		public void squeeze(quotient_.Positive1 diameter)
		{

			arg.squeeze(diameter);
			return;
		}

	}

	
}
