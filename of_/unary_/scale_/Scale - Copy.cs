using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real.all;
using nilnul.num.real_;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using Rq = nilnul.num.real_.Quotient1;
using R = nilnul.num.RealI3;

namespace nilnul.num.real.op_.unary_
{
	[Obsolete()]
	static public class _ScaleX
	{
		static public R Scale(this R arg, Q0 scale)
		{
			if (scale==0)
			{
				return new nilnul.num.real_.Quotient1();
			}

			if (scale==1)
			{
				return arg;
			}
			
			return new _scale.Ret(arg,scale);
			//throw new NotImplementedException();
		}

		public static R Scale(Q0 a, R b)
		{
			return Scale(b, a);
			//throw new NotImplementedException();
		}

		public static R Scale(Rq scale, R x)
		{
			if (scale == 0)
			{
				return new Rq();
			}

			if (scale == 1)
			{
				return x;
			}

			if (x is nilnul.num.real_.Quotient1)
			{
				return nilnul.num.real_.quotient.op_.binary_.Multi.Singleton.op(scale.quotient, ( x as nilnul.num.real_.Quotient1 ).quotient);
			}

			return new _scale.Ret(scale,x);
		}
	}
}
