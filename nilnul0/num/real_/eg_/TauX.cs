using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_
{
	
	static public  class TauX
	{


		public const double IntoDouble = 2 * Math.PI;

		static public nilnul.num.Real _GetHalf() {
			return nilnul.num.real_.Tau.Singleton.ToReal() / 2;
		}


		static public nilnul.num.Real Half = _GetHalf();
		static public double _GetHalfD() {
			return Math.PI;
		}


		static public double HalfD = _GetHalfD();

		static public nilnul.num.Real _GetQuarter() {
			return nilnul.num.real_.Tau.Singleton.ToReal() / 4;
		}

		static public nilnul.num.Real Quarter = _GetQuarter();
		static public double QuarterD = Math.PI/2;

		static public nilnul.num.Real _GetEighth() {
			return nilnul.num.real_.Tau.Singleton.ToReal() / 8;

		}

		static public nilnul.num.Real Eighth = _GetEighth();

		static public double EighthD = Math.PI/4;

	}
}
