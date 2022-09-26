using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q = nilnul.num.quotient;
using Qr = nilnul.num.real_.Quotient;

namespace nilnul.num.real_.quotient
{
	public class Square
	{
		static public Qr Eval(Qr x) {
			return q.op_.unary_._SquareX.Square(x.boxed);
		}
	}
}
