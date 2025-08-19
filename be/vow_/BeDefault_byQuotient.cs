using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.vow_
{
	public class BeDefault_byQuotient<TBe>
	:
	nilnul.num.real.be.Vow_byQuotient
	where TBe : nilnul.obj.BeI_ofIn<nilnul.num.RealI_onQuotient>,new()
	{
		public BeDefault_byQuotient() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
