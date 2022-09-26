using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co_.divisible
{
	static public class _DivFloorX
	{

		static public BigInteger DivFloor(nilnul.num.RealI dividend, nilnul.num.real_.NonnilI divisor) {
			return nilnul.num.real._FloorX.Floor(
				co_.divisible._DivX.Bind(
					dividend
					,
					divisor
				)
			) ;
		}

		static public BigInteger DivFloor(co_.Divisible nonegPos) {
			return DivFloor(
				nonegPos.Item1,nonegPos.Item2
			) ;
		}

		static public BigInteger DivFloor(nilnul.num.RealI real, int divisor) {
			return DivFloor(
				real, new nilnul.num.real_.Nonnil(divisor)
			) ;
		}


	}
}
