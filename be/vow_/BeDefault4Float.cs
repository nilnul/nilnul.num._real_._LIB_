using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.vow_
{
	public class BeDefault4Float<TBe>
	:
	nilnul.num.real.be.Vow4float
	where TBe : nilnul.obj.BeI1<float>,new()
	{
		public BeDefault4Float() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
