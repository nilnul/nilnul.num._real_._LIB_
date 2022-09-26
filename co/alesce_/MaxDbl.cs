using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.band_
{
	public class MaxDbl : real.co.BandDblA
	{
		public override double combine(double arg, double arg1)
		{
			return arg>=arg1?arg:arg1;
		}

		static public MaxDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<MaxDbl>.Instance;
			}
		}

	}
}
