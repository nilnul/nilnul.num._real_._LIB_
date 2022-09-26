using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.vow_
{
	public class BeDefaultDbl<TBe>
	:
	nilnul.num.real.be.VowDbl
	where TBe : nilnul.obj.BeI1<double>,new()
	{
		public BeDefaultDbl() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
