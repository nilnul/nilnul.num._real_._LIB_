using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;
using N = nilnul.num.quotient_.denomNonnil_.Nonneg;

namespace nilnul.num.real.co
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	static public class _DistanceX 
	{

		static public R0 Distance(R0 a, R0 b)
		{
			return  nilnul.num.real.op_.Abs.Singleton.op(a.ToImpl() - b);

		}


		static public double Distance(double x, double y)
		{
			return Math.Abs(
				x-y
			);
		}
	}
}
