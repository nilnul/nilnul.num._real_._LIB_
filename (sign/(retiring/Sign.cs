using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.RealI2;


namespace nilnul.num.real
{
	static public  class _SignX
	{
		static public int Sig_asInt(double x) {
			if (x==0)
			{
				return 0;
				
			}
			return x > 0 ? 1 : -1;
		}

		
	}

	public class Sign
	{
		public bool? sign(R r) {
			return nilnul.num._real.approach.generator._SignX.Sign( r.choice);
		}


		static public Sign Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Sign>.Instance;
			}
		}


	}
}
