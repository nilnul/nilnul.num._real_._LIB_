using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.RealI3;


namespace nilnul.num.real
{
	[Obsolete()]
	static public  class _SignX1
	{
		static public int Int(double x) {
			if (x==0)
			{
				return 0;
				
			}
			return x > 0 ? 1 : -1;
		}

		static public bool? BitNulable(R r) {
			return nilnul.num._real.cauchy._SignX.BitNulable( r.choice);
		}

		static public int Int(R r) {
			return nilnul.num._real.cauchy._SignX.Int( r.choice);
		}


		

	}
}
