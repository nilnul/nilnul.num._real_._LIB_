using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.bi_.add
{
	static public class _CumulaX
	{
		static public IEnumerable<double> Cascade(
			IEnumerable<double> seed
			,
			IEnumerable< IEnumerable<double>> torso
		) {
			var scrolls = torso.Select(s => s.GetEnumerator());
			foreach (var item in seed)
			{
				scrolls.Each(
					s => s.MoveNext()
				);
				yield return item + nilnul.num.real.bi_.add.cumula._CumulateX.Cumulate
					///.op_.binary_.add.Cumulator.Singleton.cumulate
					(
					scrolls.Select(s => s.Current)
				);
			}

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> Cascade(
			IEnumerable<double> seed
			,
			params  IEnumerable<double>[] torso
		) {
			return Cascade(seed, (IEnumerable<IEnumerable<double>>)torso);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Cascade_0arity(
			int arity
			,
			params IEnumerable<double>[] vecs
		)
		{
			return Cascade(Enumerable.Repeat(0d, arity), vecs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Cumulate_0started(
			params IEnumerable<double>[] vecs
		)
		{
			return Cascade(vecs.First(), vecs.Skip(1));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Cumulate_0started(
			IEnumerable< IEnumerable<double>> vecs
		)
		{
			return Cascade(vecs.First(), vecs.Skip(1));
		}



	}
}
