using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_.positive_
{
	public class LtOne4Dbl
		:
		
		nilnul.num.real.BeDblI
	{
		public  bool be(double x)
		{
			return x <1 && x>0;
		}

		static public LtOne4Dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LtOne4Dbl>.Instance;
			}
		}

	}
}
