using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.op_.binary_
{
	public class Multi
		:
		BinaryI
	{
		public Frac op(Frac par, Frac par1)
		{
			return par*par1;
		}


		static public Multi Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Multi>.Instance;
			}
		}

	}
}
