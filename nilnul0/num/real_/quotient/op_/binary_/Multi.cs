using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rq = nilnul.num.real_.Quotient;

namespace nilnul.num.real_.quotient.op_.binary_
{
	public class Multi1:BinaryI
	{

		static public Multi1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi1>.Instance;
			}
		}


		public Rq op(Rq arg, Rq arg1)
		{
			return new Rq(
					arg.boxed*arg1.boxed
			);
			//throw new NotImplementedException();
		}
	}
}
