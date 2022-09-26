using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound.be.en_
{
	public class BeDefault<TBe>
		: num.real.bound.be.En
		where TBe : real.bound.BeI, new()
	{
		public BeDefault(BoundI obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
