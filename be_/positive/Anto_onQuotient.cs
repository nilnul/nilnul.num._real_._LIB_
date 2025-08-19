using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.positive
{
	public class Anto_onQuotient
		: nilnul.num.real.be.anto_.BeDefault_byQuotient<Positive>
	{

		static public Anto_onQuotient Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto_onQuotient>.Instance;
			}
		}

	}
}
