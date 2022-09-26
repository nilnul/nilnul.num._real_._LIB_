using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._cauchy;
using nilnul.num._real.approach_;
using nilnul.num._real.cauchy.be_.nonnil.vow;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real.cauchy_.nonnil.op_.unary_._inverse
{
	public class Ret :
		_call.Arg
		,
		CauchyI2
		,
		NonnilI
	{

		public En nonnil => new En(this);// throw new NotImplementedException();

		public A approach => nilnul.num._real._cauchy.approach_.nonnil.op_.unary_._InverseX.Approach(arg.nonnil.en.approach);

		public Ret(cauchy_.NonnilI x):base(x)
		{


		}

	

		public override string ToString()
		{
			return $"1/{arg}";
		}

		

		public Quotient1 next()
		{
			//'cuz the limit is nonnil, so we surely can meet a nonnil element.
			var n = arg.nonnil.en.next();
			while (n==0)
			{
				n = arg.nonnil.en.next();
			}
			return 1 / n;
			//throw new NotImplementedException();
		}
	}
}
