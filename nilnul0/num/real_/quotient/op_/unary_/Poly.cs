using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul.Num1;


namespace nilnul.num.real_.quotient.op_.unary_
{
	public class Poly:UnaryI
	{


		private N _index;
		public Poly(N index)
		{
			_index = index;
		}
		static public Quotient Op(num.real_.Quotient arg, N arg1)
		{
			return new num.real_.Quotient(

						nilnul.num.quotient.op_.unary_.Poly.Eval(arg, arg1)

				);

			//throw new NotImplementedException();
		}

		public Quotient op(num.real_.Quotient arg)
		{

			return Op(arg, _index);
		}
	}
}
