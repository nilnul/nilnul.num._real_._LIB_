using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nil
{
	public class Anto_byQuotient
		: nilnul.num.real.be.anto_.BeDefault_byQuotient<Nil>
	{

		static public Anto_byQuotient Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto_byQuotient>.Instance;
			}
		}

	}
}
