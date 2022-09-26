using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI3;
using Q0 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.stream_._cauchy;
using C = nilnul.num._real.CauchyI2;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real.cauchy.op_.unary_._shift
{


	public class Ret : 
		nilnul._call.ArgArg1A<Q0, C>
		,
		C
	{
		public Ret( Q0 shift, C arg ) : base(shift, arg)
		{
		}

		public A approach => _cauchy.approach.op_.unary_._ShiftX.Shift( arg, arg1.approach);

		public Quotient1 next()
		{
			return arg + arg1.next();
			//throw new NotImplementedException();
		}
	}
}
