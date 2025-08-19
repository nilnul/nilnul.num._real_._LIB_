using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI_onQuotient;


namespace nilnul.num.real.of_.binary_
{
	/// <summary>
	/// for double
	/// </summary>
	public class Min
		:BinaryI
		,
		Binary4dblI
	{
	
		public R op(R a, R b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b) ? a : b;

		}

		[MethodImpl( methodImplOptions: MethodImplOptions.AggressiveInlining)]
		public double op(double a, double b)
		{
			return Math.Min(a,b);
		}

		public Real4dblI op(Real4dblI par, Real4dblI par1)
		{
			return new Real4dbl( op(par.errable, par1.errable) );
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
