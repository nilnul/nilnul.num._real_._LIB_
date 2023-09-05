using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_
{
	static public class _FractileX
	{
		static public double Fractile(double x, double y) {
			return x + 1 / y;
		}
	}

	public class Fractile : of_._binary_.ByDblsI
	{
		/// <summary>
		/// it's the developer's responsibility to take account of inf,nil,nan values of inputs;
		/// </summary>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <returns></returns>
		public double op(double par, double par1)
		{
			return _FractileX.Fractile(par, par1);
		}


		static public Fractile Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Fractile>.Unison;
			}
		}

	}
}
