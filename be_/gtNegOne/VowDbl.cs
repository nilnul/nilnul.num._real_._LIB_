using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.gtNegOne
{
	public class VowDbl:nilnul.num.real.be.vow_.BeDefaultDbl<be_.GtNegOneDbl>
	{

		static public VowDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<VowDbl>.Instance;
			}
		}

	}
}
