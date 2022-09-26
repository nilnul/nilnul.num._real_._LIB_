using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class GeNegOne
		:
		BeA,
		nilnul.num.real.BeI
		,
		nilnul.num.real.BeDblI
	{
		public override bool be(Real x)
		{
			return x >= -1;
		}

		public bool be(double x)
		{
			return x >= -1;
			//throw new NotImplementedException();
		}

		static public GeNegOne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GeNegOne>.Instance;
			}
		}

	}
}
