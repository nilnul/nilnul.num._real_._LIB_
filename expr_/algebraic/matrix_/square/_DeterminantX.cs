using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.matrix_.square
{
	static public class _DeterminantX
	{
		static public Algebraic _Determinant_assumeSquare(
			this Algebraic[,] d
		) {
			var w = d.GetLength(0);
			if ( w==0)
			{
				return new Algebraic(1);
			}

			return Enumerable.Range(0, w).AsParallel().Select
				(
					i=> square.cel.remnant.minor._CofactorX._Cofactor_assumeValid(
						d
						,
						0
						,i
					) * d[ 0,i]
				).Aggregate(
				 (a,c) => a+c
				)
			;
		}
	}
}
