using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.be_
{
	[Obsolete()]
	public class Nonnil : BeI
	{
		public bool be(Quotient1 obj)
		{
			return obj != 0;
			//throw new NotImplementedException();
		}

		static public Nonnil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nonnil>.Instance;
			}
		}

	}
}
