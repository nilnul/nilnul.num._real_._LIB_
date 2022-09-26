using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be.en_
{
	public class BeDefault<TBe>
		: En
		where TBe : nilnul.obj.BeI1<LowerUpper>, new()
	{
		public BeDefault(LowerUpper obj) : base(obj, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		
	}
}
