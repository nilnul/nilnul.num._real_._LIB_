using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_
{
	public class LtTau :
		BeA
		,
		num.real.BeI
		,
		num.real.IBeOfDouble
	{
		

		public override bool be(Real x)
		{
			return num.real.be_.Nonneg.Singleton.be(x) && x < nilnul.num.real_.Tau.Singleton;
		}

		public bool be(double obj)
		{
			return obj>=0 && obj< nilnul.num.real_.TauX.IntoDouble;
		}

		static public LtTau Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtTau>.Instance;
			}
		}

	}
}
