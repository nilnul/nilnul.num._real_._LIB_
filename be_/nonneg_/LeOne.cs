using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_
{
	public class LeOne :
		
		num.real.BeDblI
		,
		num.real.IBeOfDouble
		,
		num.real.BeI
		
	{
		

		public  bool be(double x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) &&  nilnul.num.real.be_.LeOne.Singleton.be(x);
		}

		public bool be(RealI x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) &&  nilnul.num.real.be_.LeOne.Singleton.be(x);

			
		}

		static public LeOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LeOne>.Instance;
			}
		}

	}
}
