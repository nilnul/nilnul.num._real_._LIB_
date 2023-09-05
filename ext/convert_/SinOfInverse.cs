using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.convert_
{
	/// <summary>
	/// sin(1/x);
	/// this has a discontinous point at 0 no matter whatever value you specify for x=0;
	/// </summary>
	internal class SinOfInverse
	{
		static public double Op(double x) {
			return Math.Sin(1 / x);
		}
	}
}
