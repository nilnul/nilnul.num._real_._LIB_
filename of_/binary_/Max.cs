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
	public class Max
		:
		BinaryI
		,
		Binary4dblI
	{
		static public R Op(
			R a, R b
		) {
			return nilnul.num.real.re_.Ge.Lazy.re(a, b) ? a : b;
		}
		static public decimal Op(
			decimal a, decimal b
		) {
			return nilnul.num.real.re_.Gt.Lazy.re(a, b) ? a : b;
		}
		static public int Op(
			int a, int b
		) {
			return nilnul.num.integer.combine_.Max.Eval(a, b) ;
		}

		public R op(R a, R b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, b) ? a : b;
			throw new NotImplementedException();
		}

		public double op(double par, double par1)
		{
			return Math.Max(par, par1);
		}


		static public Max Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Max>.Instance;
			}
		}

	}
}
