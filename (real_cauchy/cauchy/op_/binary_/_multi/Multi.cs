using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._cauchy;

namespace nilnul.num._real.cauchy.op_.binary_._multi
{


	public class Ret : nilnul.num._real.cauchy._call.ArgArg1
		, CauchyI2
	{
		public Ret(CauchyI2 arg, CauchyI2 arg1) : base(arg, arg1)
		{
		}

		public _cauchy.ApproachI approach => _real._cauchy.approach.op_.binary_._MultiX.Op(arg.approach, arg1.approach);



		public Quotient1 next()
		{
			return arg.next() * arg1.next();
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{arg}{Multi.Sign}{arg1}";
		}
	}

}
