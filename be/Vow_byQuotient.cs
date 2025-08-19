using nilnul.num.real_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	public class Vow_byQuotient
		:
		nilnul.obj.be.Vow_ofIn<num.RealI_onQuotient>
		,
		real.VowI_byQuotient

	{
		public Vow_byQuotient(BeI_ofIn<num.RealI_onQuotient> be) : base(be)
		{
		}


		public Vow_byQuotient(in BeI_ofIn<RealI_onQuotient> val) : base(val)
		{
		}

		
	}
}
