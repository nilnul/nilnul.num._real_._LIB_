using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI3;

using N = nilnul.Num;


namespace nilnul.num.real.op_.unary_
{

	static public class _PolyX
		
	{


		static public R Op(R arg, N index)
		{
			if (arg is nilnul.num.real_.Quotient1)
			{
				return nilnul.num.real_.quotient.convert_.Poly.Eval(arg as nilnul.num.real_.Quotient, index);
			}
			return new _poly.Ret(arg, index);

		}


	}
}
