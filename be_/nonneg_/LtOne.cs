using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_
{
	public class LtOne :
		
		num.real.BeDblI
		,
		num.real.IBeOfDouble
		,
		num.real.BeI
		
	{
		

		public  bool be(double x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) &&  nilnul.num.real.be_.LtOne.Singleton.be(x);
		}

		public bool be(RealI x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) &&  nilnul.num.real.be_.LtOne.Singleton.be(x);

			
		}

		static public LtOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtOne>.Instance;
			}
		}

	}
}
