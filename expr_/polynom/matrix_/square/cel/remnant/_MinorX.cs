using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_.algebraic.matrix.cel;


namespace nilnul.num.real.expr_.algebraic.matrix_.square.cel.remnant
{
	static public class _MinorX
	{
		static public Algebraic _Minor_assumeValid(this Algebraic[,] matrix, int celRow, int j) {

			return  	_DeterminantX._Determinant_assumeSquare(

				matrix._Remnant_assumeValid(celRow, j) 
			);

		


			
		}
	}
}
