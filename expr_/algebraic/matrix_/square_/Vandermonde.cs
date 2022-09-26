using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.matrix_.square_
{
	static public class _VandermondeX
	{
		static public Algebraic[,] Of(params num.real.expr_.Var1[] vars) {

		//	var varsCount = vars.Length;
			var width = vars.Length;// + 1;

			var r = new Algebraic[
				width,
				width
			];

			for (int col = 0; col < width; col++)
			{
				r[0, col] =  Algebraic.One;
			}

			for (int row = 1; row < width; row++)
			{
				for (int col = 0; col < width; col++)
				{
					r[row, col] = new Algebraic(
						new _algebraic.Pow_indexPositive( 
							vars[col]
							,
							row
						)
					);
				}
			}

			return r;
		}

		static public Algebraic[,] Colwise(params num.real.expr_.Var1[] vars) {

		//	var varsCount = vars.Length;
			var width = vars.Length;// + 1;

			var r = new Algebraic[
				width,
				width
			];

			///for col0
			for (int row0 = 0; row0 < width; row0++)
			{
				r[ row0,0] =  Algebraic.One;
			}

			for (int col = 1; col < width; col++)
			{
				for (int row00 = 0; row00 < width; row00++)
				{
					r[ row00,col] = new Algebraic(
						new _algebraic.Pow_indexPositive( 
							vars[row00]
							,
							col
						)
					);
				}
			}

			return r;
		}

	}
}
