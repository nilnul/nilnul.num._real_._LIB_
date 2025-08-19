using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.matrix_.square_.vandermonde
{
	static public class _DeterminantX
	{
		/// <summary>
		/// by brute force;
		/// </summary>
		/// <param name="vars"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(DeterminantOfVars_byProduct) + " is preferred as this is too slow;")]
		static public Algebraic DeterminantOfVars(params num.real.expr_.Var1[] vars) {

			return matrix_.square._DeterminantX._Determinant_assumeSquare(
				_VandermondeX.Of(vars)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vars"></param>
		/// <returns></returns>
		static public Algebraic DeterminantOfVars_byProduct(params num.real.expr_.Var1[] vars) {
			var width = vars.Length;

			var algebras = vars.Select(v=> new _algebraic.Pow_indexPositive(v) ).ToArray();

			IEnumerable<Algebraic> terms()
			{

				for (int i = 0, iInc = 1; i < width; i = iInc, iInc++)
				{

					for (int j = iInc; j < width; j++)
					{
						yield return algebras[j] - algebras[i];
					}
				}
			}

			return algebraic.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(
				terms()
			);
		}

	}
}
