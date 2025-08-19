using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient_;
using nilnul.obj.stream_._slider._skid_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.op_._abs
{


	public  class Ret
		:
		nilnul.num.real.calc_._unary.Arg
		,
		RealI_onQuotient
	{

		public Ret(RealI_onQuotient a)
			: base(a)
		{

		}

		public (Q4 begin, Q4 end) current
		{
			get
			{

				return nilnul.num.quotient.clasp.op_._AbsX._Op_0clasp(arg.current);


			}
		}


		public void cinch(quotient_.denomNonnil_.Positive diameter)
		{
			
			arg.cinch(diameter);
		}
	}

}
