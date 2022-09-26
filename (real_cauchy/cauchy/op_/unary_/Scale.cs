using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q0 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using C = nilnul.num._real.CauchyI2;
namespace nilnul.num._real.cauchy.op_.unary_
{
	static public class _ScaleX
	{

		static public C Scale(this C arg, Q0 scale)
		{
			if (scale==0)
			{
				return new nilnul.num._real.cauchy_.Quotient();
			}
			return new _scale.Ret(scale,arg);
			//throw new NotImplementedException();
		}

		
	}
}
