using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str
{
	public static class _ProdX
	{
		static public float Prod(float x, float y, float z) {
			return x * y * z;
		}

		static public R Prod_recur(this IEnumerable<R> x) {
			if (x.None())
			{
				return new nilnul.num.real_.Quotient(1);
			}

			return nilnul.num.real.op_.binary_.Multi.Singleton.op(x.First(), Prod_recur(x.Skip(1)));

		}
		static public Real Prod_byLoop(this IEnumerable<R> x) {
			

			Real r = new nilnul.num.real_.Quotient(1);
			foreach (var item in x)
			{
				r *= item;
			}

			return r;
			

		}



	}
}
