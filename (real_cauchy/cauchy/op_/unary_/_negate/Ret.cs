using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using R = nilnul.num.RealI2;
using C = nilnul.num._real.CauchyI2;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real.cauchy.op_.unary_._negate
{


	public class Ret : nilnul.num._real.cauchy._call.Arg
		,
		C 
	{
		public Ret(C arg) : base(arg)
		{
		}

		public A approach =>   nilnul.num._real._cauchy.approach.op_.unary_.Negate.Singleton.op(arg.approach);
			

		public Quotient1 next()
		{
			return -arg.next();

		}
	}

}
