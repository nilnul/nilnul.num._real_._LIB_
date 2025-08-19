using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.str_.started.braid_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ProdX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="seed">
		/// we need this to determine the length of the vec. a vec of <see cref="num.real.vec_."/>
		/// </param>
		/// <param name="vecs"></param>
		/// <returns></returns>
		static public IEnumerable<double> Product(
			IEnumerable<double> seed
			,
			IEnumerable< IEnumerable<double>> vecs
		) {
			var scrolls = vecs.Select(s=>s.GetEnumerator());
			foreach (var item in seed)
			{
				scrolls.Each(
					s=>s.MoveNext()
				);
				yield return item* nilnul.num.real.op_.binary_.multi.Cumulator4dbl.Singleton.accumulate(
					scrolls.Select(s=>s.Current)
				);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> Product(
			IEnumerable<double> seed
			,
			params IEnumerable<double>[] vecs
		) {
			return Product(seed, (IEnumerable<IEnumerable<double>>)vecs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Product_0arity(
			int arity
			,
			params IEnumerable<double>[] vecs
		) {
			return Product(Enumerable.Repeat(0d,arity) , vecs);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> Prod_assumeStartedVecs(
			params IEnumerable<double>[] vecs
		) {
			return Product(vecs.First(),vecs.Skip(1));
		}


	}
}
