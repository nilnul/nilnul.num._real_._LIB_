using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class Parse
	{

		static public decimal ToDecimal_zeroIfException(string txt) {
			decimal r;
			if (decimal.TryParse(txt, out r)) {
				return r;
			}
			return 0;
		}

		static public decimal ToDecimal_defaultIfException(string txt, decimal fallback=0)
		{
			decimal r;
			if (decimal.TryParse(txt, out r))
			{
				return r;
			}
			return fallback;
		}



	}
}
