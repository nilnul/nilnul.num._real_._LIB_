using nilnul.obj.be.vow_.xpN_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.en_
{
	public class BeDefaulted<TBe>
		: nilnul.num.real.be.En4
		where TBe : nilnul.num.real.BeI,new()
	{
		

		public BeDefaulted(RealI obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}
