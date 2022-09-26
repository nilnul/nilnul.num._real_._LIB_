using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	[MayPerpetual]
	static public  class _SignX
	{
		[MayPerpetual]
		static public bool? BitNul(R real) {
			_sign._TrichotomyX.Void(real);
			return nilnul.num.quotient._SignX1.BitNulable(real.current.lower.mark);
		}

		public static int Int(R approach)
		{
			_sign._TrichotomyX.Void(approach);
			return nilnul.num.quotient._SignX1.Int(approach.current.lower.mark);
		}
	}

	public class Sign : nilnul.obj.SignI<R>
	{
		public bool? sign(R obj)
		{
			return _SignX.BitNul(obj);
		}


		static public Sign Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sign>.Instance;
			}
		}

	}
}