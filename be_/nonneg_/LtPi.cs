using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_
{
	public class LtPi :
		BeA
		,
		num.real.BeI
	{
		

		public override bool be(Real x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) && x < nilnul.num.real_.Tau.Singleton.ToReal()/2;
		}

		static public LtPi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtPi>.Instance;
			}
		}

	}
}
