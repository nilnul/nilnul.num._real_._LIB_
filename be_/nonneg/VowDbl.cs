using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg
{
	public class VowOfDouble:nilnul.num.real.be.VowOfDouble<be_.NonnegOfDouble>
	{

		static public VowOfDouble Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<VowOfDouble>.Instance;
			}
		}

	}
}
