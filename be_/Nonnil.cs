using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class Nonnil
		:
		nilnul.num.real.BeDblI
	{

		public bool be(double real)
		{

			return real != 0;

			//throw new NotImplementedException();
		}



		static public Nonnil Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonnil>.Instance;
			}
		}



	}
}
