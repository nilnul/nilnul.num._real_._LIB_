using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using C = nilnul.num._real.CauchyI2;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real.cauchy.op_.binary_._minus
{

	public class Ret : nilnul._call.argArg1_.Closed<C>
		, C
	{

		public Ret(C arg, C arg1) : base(arg, arg1)
		{
		}

		public A approach =>
				 _cauchy.approach.op_.binary_.Minus.Op(arg.approach, arg1.approach);

		public Quotient1 next()
		{
			return arg.next() - arg1.next();
			//throw new NotImplementedException();
		}
	}


}
