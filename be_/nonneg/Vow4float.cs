using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg
{
	public class Vow4float:nilnul.num.real.be.vow_.BeDefault4Float<be_.Nonneg4float>
	{

		static public Vow4float Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow4float>.Instance;
			}
		}

	}
}
