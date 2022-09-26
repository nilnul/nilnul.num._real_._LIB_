using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class NegOfDouble
		: nilnul.num.real.IBeOfDouble
		,
		nilnul.num.real.BeDblI
	{

		public bool be(double real)
		{

			return real < 0;

			//throw new NotImplementedException();
		}


		static public NegOfDouble Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NegOfDouble>.Instance;
			}
		}


	}
}
