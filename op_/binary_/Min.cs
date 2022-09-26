using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.op_.binary_
{
	/// <summary>
	/// for double
	/// </summary>
	public class Min
		:BinaryI
		,
		Binary4dblI
	{
		static public R Eval(
			R a, R b
		) {
			return nilnul.num.real.re_.Le.Lazy.re(a, b) ? a : b;
		}



		static public double Op(double x, double y) {
			return x <= y ? x : y;
		}

		public R op(R a, R b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b) ? a : b;

		}

		public double op(double a, double b)
		{
			return Math.Min(a,b);

		}

		static public Min Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Min>.Instance;
			}
		}

	}
}
