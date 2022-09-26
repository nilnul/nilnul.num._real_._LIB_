using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.band_
{
	static public class _SquareSumX
	{
		static public nilnul.num.Real Real(nilnul.num.RealI x, nilnul.num.RealI y)
		{
			return nilnul.num.real.op_.unary_._SquareX.Op(
					x
			).ToReal()
			+
			nilnul.num.real.op_.unary_._SquareX.Op(
				y
			)
			;

		}

		static public double Dbl(double x, double y)
		{
			return nilnul.num.real.op_.unary_.Square.Singleton.op(
					x
			)
			+
			nilnul.num.real.op_.unary_.Square.Singleton.op(
				y
			)
			;

		}

	}
}
