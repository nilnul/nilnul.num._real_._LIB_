using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;
using R1 = nilnul.num.RealI2;




namespace nilnul.num.real.duo.op_
{


	public static class X
	{
		static public R1 Multi(this R1 x, R1 y)
		{
			return duo.op_.Multi.Singleton.eval(x, y);
		}

		static public R1 Multi(this int x, R1 y)
		{
			return duo.op_.Multi.Singleton.eval(x, y);
		}

	}
}
