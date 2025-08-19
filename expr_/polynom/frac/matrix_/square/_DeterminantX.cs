using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.matrix_.square
{
	static public class _DeterminantX
	{
		static public Frac _Determinant_assumeSquare(
			this Frac[,] d
		) {
			var width = d.GetLength(0);
			if ( width ==0)
			{
				return new Frac(1);
			}

			return Enumerable.Range(0, width).AsParallel().Select
				(
					i=> square.cel.remnant.minor._CofactorX._Cofactor_assumeValid(
						d
						,
						0
						,
						i
					)
				).Aggregate(
					(a,c) => a+c
				)
			;
		}
	}
}
