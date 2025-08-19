using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real.all;
using nilnul.num.real_;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.op_
{
	
	[Obsolete()]

	static public class _ScaleX
	{
		

		static public num.RealI2 Scale(this num.RealI2 arg, Q scale)
		{
			if (scale==0)
			{
				return new nilnul.num.real_.Quotient();

			}

			if (scale==1)
			{
				return arg;
			}
			
			return
				
				new _scale.Ret(arg,scale);

			//throw new NotImplementedException();
		}

		public static num.RealI2 Scale(Q a, R b)
		{
			return Scale(b, a);
			//throw new NotImplementedException();
		}

		internal static R Scale(real_.Quotient scale, R x)
		{

			if (scale == 0)
			{
				return new nilnul.num.real_.Quotient();

			}

			if (scale == 1)
			{
				return x;
			}

			if (x is nilnul.num.real_.Quotient)
			{
				return nilnul.num.real_.quotient.combine_.Multi.Singleton.eval(scale.q, ( x as nilnul.num.real_.Quotient ).q);
			}

			return

				new _scale.Ret(scale,x);

			//throw new NotImplementedException();
		}
	}
}
