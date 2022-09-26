using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.neg
{
	public class Vow4dbl:nilnul.num.real.be.vow_.BeDefaultDbl<be_.NegOfDouble>
	{

		static public Vow4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow4dbl>.Instance;
			}
		}

	}
}
