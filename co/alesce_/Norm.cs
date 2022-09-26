using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.band_
{
	static public class _NormX
	{
		static public nilnul.num.RealI RealI(nilnul.num.RealI x, nilnul.num.RealI y)
		{
			return nilnul.num.real.op_.unary_.Sqrt.Singleton.op(
				_SquareSumX.Real(x,y)
			)
			;

		}
		static public double Dbl(double x, double y)
		{
			return Math.Sqrt(
				_SquareSumX.Dbl(x,y)
			)
			;

		}


	}
}
