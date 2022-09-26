using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_.algebraic.matrix.cel;


namespace nilnul.num.real.expr_.algebraic.matrix_.square.cel.remnant.minor
{
	static public class _CofactorX
	{
		static public Algebraic _Cofactor_assumeValid(this Algebraic[,] matrix, int celRow, int j) {

			return nilnul.num.integer.op_.unary_.polyn._BaseNegOneX.OfNegOneAsInt(celRow +j)  
				* _MinorX._Minor_assumeValid(

				matrix,celRow, j 
			);

		


			
		}
	}
}
