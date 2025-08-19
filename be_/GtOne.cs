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
	///		surnorm, <seealso cref="GeOne"/>
	public class GtOne
		:
		BeA,
		nilnul.num.real.BeI
		,
		nilnul.num.real._be_.OfImplI

		,
		nilnul.num.real.BeI_onQuoient

	{
		public override bool be(Real x)
		{
			return x >1;
		}

		public bool be(in R0 val)
		{
			return be(
				val.ToImpl()
			);
		}

		public bool be(in Real_onQuotient val)
		{
			return val>1;
		}

		static public GtOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GtOne>.Instance;
			}
		}

	}
}
