using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	static public class _ProperX
	{
		[MayPerpetual]
		static public BigInteger Floor(
			this nilnul.num.RealI real
		) {
			nilnul.num.RealIX._Clamp2UnitFrac(real, 2);

			while (true)
			{
				var lowerFloor = nilnul.num.quotient._FloorX.Floor(
					real.current.lower.mark
				);
				var upperFloor = nilnul.num.quotient._FloorX.Floor(
					real.current.upper.mark
				);

				if (
					lowerFloor
					<
					upperFloor
				)
				{
					real.Clamp1K();
				}
				else
				{
					return lowerFloor;
				}
			}
		}
	}
	
}
