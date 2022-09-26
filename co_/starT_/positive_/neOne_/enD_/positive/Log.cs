using nilnul.bit.var.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co_.starT_.positive_.neOne_.enD_.positive
{
	static public class _LogX
	{
		static public nilnul.num.RealI Log(
			nilnul.num.real_.positive_.NeOne basis
			,
			nilnul.num.real_.Positive index
			) {
			return nilnul.num.real_.positive.ln_._ByReverseExpX.RetReal(basis)
				/ nilnul.num.real_.positive.ln_._ByReverseExpX.RetRealI(index)
				;
		}

		public static RealI Log(RealI argSquared, Real ratio)
		{
			return Log(
				new nilnul.num.real_.positive_.NeOne(argSquared)
				,
				new nilnul.num.real_.Positive(ratio)
			);
			;
		}
	}
}
