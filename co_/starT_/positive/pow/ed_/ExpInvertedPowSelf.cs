using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co_.starT_.positive.pow.ed_
{
	static public class _ExpInvertedPowSelfX
	{
		static public nilnul.num.RealI Calc() {
			return _PowX.RetRealI(
				nilnul.num.real_.euler._InvertedX.Cached
				,
				nilnul.num.real_.euler._InvertedX.Cached

			);
		}

		static public nilnul.num.RealI Cached = Calc();
	}
}
