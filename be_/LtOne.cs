using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class LtOne
		:
		BeA,
		nilnul.num.real.BeI
		,
		BeDblI
	{
		public override bool be(Real x)
		{
			return x < 1;
		}

		public bool be(double obj)
		{
			return obj < 1;
			throw new NotImplementedException();
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
