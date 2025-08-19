using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient_;
using q = nilnul.num.quotient;

namespace nilnul.num.real.op_.unary_._abs
{


	public  class Ret
		:
		nilnul.num.real._call_.Arg
		,
		RealI
	{

		public Ret(RealI a)
			: base(a)
		{

		}

		public q.bound_.Closed current
		{
			get
			{

				return nilnul.num.quotient.bound_.closed.op_.unary_._AbsX.Op(arg.current);


			}
		}

		

		public void squeeze(Positive1 diameter)
		{
			arg.squeeze(diameter);
		}
	}

}
