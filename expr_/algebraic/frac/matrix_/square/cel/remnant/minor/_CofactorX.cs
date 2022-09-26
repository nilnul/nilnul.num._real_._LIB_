using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_.algebraic.frac.matrix.cel;


namespace nilnul.num.real.expr_.algebraic.frac.matrix_.square.cel.remnant.minor
{
	static public class _CofactorX
	{
		static public Frac _Cofactor_assumeValid(this Frac[,] matrix, int celRow, int j) {

			return nilnul.num.int_.MinusOnePow.Eval(celRow +j)  
				* _MinorX._Minor_assumeValid(

				matrix,celRow, j 
			);

		


			
		}
	}
}
