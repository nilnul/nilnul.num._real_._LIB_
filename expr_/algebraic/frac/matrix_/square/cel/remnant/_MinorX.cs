using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_.algebraic.frac.matrix.cel;


namespace nilnul.num.real.expr_.algebraic.frac.matrix_.square.cel.remnant
{
	static public class _MinorX
	{
		static public Frac _Minor_assumeValid(this Frac[,] matrix, int celRow, int j) {

			return 	_DeterminantX._Determinant_assumeSquare(

				matrix._Remnant_assumeValid(celRow, j) 
			);

		


			
		}
	}
}
