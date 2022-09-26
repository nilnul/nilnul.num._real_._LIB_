using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class GtNegOneDbl
		:
		
		nilnul.num.real.BeDblI
	{
		public  bool be(double x)
		{
			return x > -1;
		}

		static public GtNegOneDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GtNegOneDbl>.Instance;
			}
		}

	}
}
