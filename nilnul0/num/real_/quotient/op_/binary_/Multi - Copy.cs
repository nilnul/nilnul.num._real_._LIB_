using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rq = nilnul.num.real_.Quotient1;

namespace nilnul.num.real_.quotient.op_.binary_
{
	[Obsolete()]
	public class Multi:BinaryI
	{


		static public Multi Singleton
		{
			get
			{
				return nilnul.Singleton1<Multi>.Instance;
			}
		}



		public Rq op(Rq arg, Rq arg1)
		{
			return new Rq(
					arg.quotient*arg1.quotient
				);

			//throw new NotImplementedException();
		}

		
	}
}
