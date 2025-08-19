using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_.positive_
{
	public class LeOne4Dbl
		:
		
		nilnul.num.real.BeDblI
	{
		public  bool be(double x)
		{
			return x <=1 && x>0;
		}

		static public LeOne4Dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<LeOne4Dbl>.Instance;
			}
		}

	}
}
