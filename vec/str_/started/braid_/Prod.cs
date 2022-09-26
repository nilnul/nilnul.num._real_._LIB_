using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.str_.started.braid_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ProdX
	{
		static public IEnumerable<double> Prod_assumeStartedVecs(
			params IEnumerable<double>[] vecs
		) {


			var scrolls = vecs.Select(s=>s.GetEnumerator());
			//var vec1st = vecs.First().GetEnumerator();
			var vec1st = scrolls.First();



			while (vec1st.MoveNext())
			{
				scrolls.Each(
					s=>s.MoveNext()
				);

				yield return nilnul.num.real.op_.binary_.multi.Cumulator4dbl.Singleton.accumulate(
					scrolls.Select(s=>s.Current)
				);

			}

		}
	}
}
