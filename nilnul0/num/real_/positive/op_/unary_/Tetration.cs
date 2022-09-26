using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positive.op_.unary_
{
	static public class _TetrationX
	{
		static public nilnul.num.real_.Positive Op(nilnul.num.real_.Positive x, ulong y) {
			if (y==0)
			{
				return new Positive( 1 );
			}
			return
				nilnul.num.real.co_.starT_.positive._PowX.RetPositive(x,
					Op(
					x, y-1
					)
				);
		}

	}
}
