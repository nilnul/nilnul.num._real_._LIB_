using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI3;
using nilnul.num._real.approach.generator.op_._negate;
using nilnul.num.quotient.stream_;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num.real.op_.unary_._neg
{
	[Obsolete()]
	public class Ret
		: nilnul.num.real._call.Arg
		, R
	{
		public Ret(R arg) : base(arg)
		{

		}

		public 	C choice 
		{
			get
			{
				return  nilnul.num._real.cauchy.op_.unary_.Negate.Singleton.op(arg.choice);

				//throw new NotImplementedException();
			}
		}

	}
}
