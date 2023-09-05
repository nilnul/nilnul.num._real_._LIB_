using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary.cumulator_
{
	public class Sum4dbl :
		cumulator_.opDefault_.IniDefault4Dbl<nilnul.num.real.op_.binary_.Add>
		

	{
		

		static public Sum4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sum4dbl>.Instance;
			}
		}

	}
}
