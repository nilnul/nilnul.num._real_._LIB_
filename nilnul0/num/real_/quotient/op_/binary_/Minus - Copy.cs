using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.op_.binary_
{
	public class Minus:BinaryI
	{



		public Quotient1 op(Quotient1 arg, Quotient1 arg1)
		{
			return new Quotient1(
					arg.quotient-arg1.quotient				
				);

			//throw new NotImplementedException();
		}


		static public Minus Singleton
		{
			get
			{
				return nilnul.Singleton1<Minus>.Instance;
			}
		}

	}
}
