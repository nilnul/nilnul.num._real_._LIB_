using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.pons.prod
{
	/// <summary>
	/// </summary>
	public class Eq
		:
		nilnul.obj.ReI<
			Product
		>
		,
		IEqualityComparer<Product>
	{
		public bool _re_assumeSimplified(Product a, Product b)
		{
			return new nilnul.obj.set_.EqDefaulted<Ponent, pon.Eq>(a.ponents).SetEquals(
new nilnul.obj.set_.EqDefaulted<Ponent, pon.Eq>(b.ponents)
			);
		}

		public bool re(Product a, Product b)
		{
			return _re_assumeSimplified(
				a.asSimplify()
				,
				b.asSimplify()
			);
		}

		public bool Equals(Product a, Product b)
		{
			return object.ReferenceEquals(a,b) || re(
				a
				,
				b
			);
		}

		public int GetHashCode(Product obj)
		{
			return 0;
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}

	}
}
