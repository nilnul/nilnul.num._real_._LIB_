using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.vow_
{
	public class BeDefault<TBe>
	:
	nilnul.num.real.be.Vow1
	where TBe : nilnul.obj.BeI1<nilnul.num.RealI>,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
