using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real_.floored
{
	/// <summary>
	/// alias:
	///		mantissa
	///		proper; but proper is used to describe a whole number, not part of it.
	/// </summary>
	static public class _TailX
	{

		static public R  RealI(nilnul.num.RealI result) {



			return nilnul.num.real.op_.binary_.Minus.Singleton.op (
				result, nilnul.num.real._FloorX.Floor(
					result
				)
			);
		}

		static public double  Doub(double result) {

			var r = (
				result - Math.Floor(
					result
				)
			);

			if (r==1) //sometimes when result is small enough
			{
				return 0;
			}

			return  r;
		}




	}
}
