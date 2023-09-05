using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.co.vow
{
	public class En:nilnul.obj.vow.En< nilnul.num.real.border.Co>
	{
		public En(nilnul.num.real.border.Co co, nilnul.num.real.border.co.VowI vow):base(vow,co)
		{

		}

	}

	public class En<T> : En
		where T : nilnul.num.real.border.co.VowI, new()
	{
		public En(Co co) : base(co, nilnul.obj_.Singleton<T>.Instance)
		{
		}
	}
}
