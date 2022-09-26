using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.approach.duo_.divisible.op_
{
	public class Divide
	{

		static public ApproachI1 Eval(
			ApproachI1 x
			,
			approach.be_.Nonzero.En y

		)
		{
			return new _divide.Call(x, y);
		}

		static public ApproachI1 _Eval(
			ApproachI1 x
			,
			ApproachI1 y_nonZero

		)
		{
			return Eval( x, new be_.Nonzero.En(y_nonZero));
		}

		
	}
}
