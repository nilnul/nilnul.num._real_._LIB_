using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._cauchy;

namespace nilnul.num._real.cauchy.op_.unary_._square
{


	public class Of : nilnul.num._real.cauchy._call.Arg
		, CauchyI2
	{
		public Of(CauchyI2 arg) : base(arg)
		{
		}

		public _cauchy.ApproachI approach => _real._cauchy.approach.op_.unary_._SquareX.Approach(arg.approach);



		public Quotient1 next()
		{
			return nilnul.num.quotient.op_.unary_._SquareX.Square(arg.next());// * arg1.next();
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{arg}**2";
		}
	}

}
