using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.convert_
{
	[Obsolete(nameof(real.str.op_.unary_._SquareX))]
	public class Square
	{
		static public IEnumerable<double> Eval(IEnumerable<double> a) {
			return  a.Select(x=> nilnul.num.real.op_.unary_.Square.Lazy.op(x));
		}

		static public IEnumerable<decimal> Eval(IEnumerable<decimal> a) {
			return  a.Select(x=> nilnul.num.real.op_.unary_.Square.Lazy.op(x));
		}

	}
}
