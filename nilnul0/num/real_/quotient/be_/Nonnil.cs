using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.be_
{
	public class Nonnil1 : BeI1
	{
		public bool be(Quotient obj)
		{
			return obj != 0;
			//throw new NotImplementedException();
		}


		static public Nonnil1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonnil1>.Instance;
			}
		}


	}
}
