using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.op_.binary_
{
	public class Minus1:BinaryI
	{

		public Quotient op(Quotient arg, Quotient arg1)
		{
			return new Quotient(
				arg.boxed-arg1.boxed
			);

			//throw new NotImplementedException();
		}


		static public Minus1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus1>.Instance;
			}
		}

	}
}
