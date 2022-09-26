using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.str.accumulate_
{
	/// <summary>
	/// as this is accumulate, hence the arity wouldnot change.
	/// </summary>
	static public class _LinearCombinateX
	{


		/// <summary>
		/// when viewed as matrix, the left must be viewed as a str of cols.
		/// </summary>
		/// <param name="_basis_vecAssumeEquicount"></param>
		/// <param name="_coeff_assumeEqBasisVecsCount"></param>
		/// <returns></returns>
		public static IEnumerable<double> _LinearCombinateAsNulable_assumeEquicount(
			this
			IEnumerable<IEnumerable<double>> _basis_vecAssumeEquicount
			,

			 IEnumerable<double> _coeff_assumeEqBasisVecsCount

		)
		{
			var zipped = _coeff_assumeEqBasisVecsCount.Zip(
				_basis_vecAssumeEquicount,

				(x, y) => num.real.str.op_.unary_._ScaleX.Scale(y, x)
			);

			if (zipped.Any())
			{

				return zipped.Aggregate(
					(a, c) =>
					a.Zip(c, (u, v) => u + v)
				);
			}

			///both args are empty.
			///the arity of the vec is unknown. If it were known, we may return [0,...,0], which is the origin, in a n-dimensional space, where n is unknown.
			return null;


		}


		[Obsolete(nameof(_LinearCombinateAsNullable_assumeEquicount))]
		public static IEnumerable<double> _LinearCombinateAsNullable_assumeEquicount(
			this
			IEnumerable<IEnumerable<double>> _basis_vecAssumeEquicount
			,

			 IEnumerable<double> _coeff_assumeEqBasisVecsCount

		)
		{
			return _LinearCombinateAsNulable_assumeEquicount(
				_basis_vecAssumeEquicount
				,
				_coeff_assumeEqBasisVecsCount
			);


		}
		/// <summary>
		/// the right par must be taken as rows when viewed as matrix.
		/// </summary>
		/// <param name="combinator">
		/// the coords for the bases. Note: the coords might be less or more than the bases's component's rank.
		/// </param>
		/// <param name="bases">
		/// taken as a matrix, a str of cols; each col is the vec.
		/// </param>
		/// the order of this two pars matches the matrix multi.
		/// <returns></returns>
		public static IEnumerable<double> _LinearCombinateAsNulable_assumeEquicount(
			this
			 IEnumerable<double> combinator
			,

			IEnumerable<IEnumerable<double>> bases


		)
		{
			return bases._LinearCombinateAsNullable_assumeEquicount(combinator);


		}
	}
}
