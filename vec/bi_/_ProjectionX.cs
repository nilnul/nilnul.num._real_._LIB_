using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.bi_
{
    static public class _ProjectionX
    {
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// in line with <see cref="vecs.to_._ortho_.by_.IGramSchmidt"/>;
		/// also in alignment when u is scaled like normalized.
		/// </remarks>
		/// <param name="v"></param>
		/// <param name="basis"></param>
		/// <returns></returns>
		///
		///
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Projection_1basis(IEnumerable<double> v, IEnumerable<double> basis) {

			return real.str.op_._ScaleX.Scale(
				basis
				,

				vec.co._InnerProductX._InnerProduct_assumeEquisize(
					v
					, basis
				)
				/ real.str._VarianceX.Variance(basis)
			);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q4> _Projection_1unnil(IEnumerable<Q4> v, IEnumerable<Q4> basis) {

			return real.str.op_._ScaleX.Scale(
				basis
				,

				vec.co._InnerProductX._InnerProduct_1equisize(
					v
					, basis
				)
				/ real.str.scala_._PotenceX.Potence(basis)
			);

		}

    }
}
