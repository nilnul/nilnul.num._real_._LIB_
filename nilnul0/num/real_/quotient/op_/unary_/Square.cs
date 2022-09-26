using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qr = nilnul.num.real_.Quotient;
using q = nilnul.num.quotient.op.SquareX;

namespace nilnul.num.real_.quotient.op_.unary_
{
	public class Square
	{
		static public Qr Eval(Qr x) {
			return nilnul.num.quotient.op_.unary_._SquareX.Square(x);
		}
	}
}
