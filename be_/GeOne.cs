using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		supnorm
	public class GeOne
		:
		BeA,
		nilnul.num.real.BeI
		,
		nilnul.num.real.BeI_onQuoient
		,
		nilnul.num.real._be_.OfImplI


	{
		public override bool be(Real x)
		{
			return x>=1;
		}


		public bool be(in Real_onQuotient val)
		{
			return val  >= 1;
		}
		public bool be(in R0 val)
		{
			return be(val.ToImpl());
		}

		static public GeOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GeOne>.Instance;
			}
		}

	}
}
