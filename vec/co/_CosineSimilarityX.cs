using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.co
{
	static public class _CosineSimilarityX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// the expression is <see cref="real.expr_.algeaic_.IIrrationale"/>. to Make it <see cref="real.expr_.algeaic_.IRationale"/>, try to square it, and take the sign separately.
		/// </remarks>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>
		///The resulting similarity ranges from −1 meaning exactly opposite, to +1 meaning exactly the same, with 0 indicating orthogonality or decorrelation, while in-between values indicate intermediate similarity or dissimilarity.
		/// </returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _CosineSimilarity_1equisize(
			IEnumerable<double> a
			,
			IEnumerable<double> b
		) {
			return co._InnerProductX._InnerProduct_1equisize(a, b) / Math.Sqrt(
				num.real.str._VarianceX.Variance(a)
				*
				num.real.str._VarianceX.Variance(b)
			);
		}
	}
}
