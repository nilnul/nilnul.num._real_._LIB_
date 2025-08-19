using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.matrix_
{
	/// <summary>
	/// named after Alexandre-Théophile Vandermonde, is a matrix with the terms of a geometric progression in each row;
	/// </summary>
	static public class _VandermondeX
	{
		/// <summary>
		/// rowwise;
		/// </summary>
		/// <param name="rows"></param>
		/// <param name="vars"></param>
		/// <returns></returns>
		static public Algebraic[,] Of(int rows, params num.real.expr_.Var1[] vars) {

		//	var varsCount = vars.Length;
			var width = vars.Length;// + 1;

			var r = new Algebraic[
				rows,
				width
			];

			for (int col = 0; col < width; col++)
			{
				r[0, col] =  Algebraic.One;
			}

			for (int row = 1; row < rows; row++)
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

		static public Algebraic[,] Colwise(int cols, params num.real.expr_.Var1[] vars) {

		//	var varsCount = vars.Length;
			var width = vars.Length;// + 1;

			var r = new Algebraic[
				width,
				cols
			];

			///for col0
			for (int row0 = 0; row0 < width; row0++)
			{
				r[ row0,0] =  Algebraic.One;
			}

			for (int col = 1; col < cols; col++)
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
