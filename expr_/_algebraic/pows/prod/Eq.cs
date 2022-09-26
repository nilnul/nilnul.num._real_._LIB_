using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod
{
	/// <summary>
	/// </summary>
	public class Eq
		:
		nilnul.obj.ReI<
			Product_ofPositivePow
		>
		,
		IEqualityComparer<Product_ofPositivePow>
	{
		public bool _re_assumeSimplified(Product_ofPositivePow a, Product_ofPositivePow b)
		{
			return new nilnul.obj.set_.EqDefaulted<Pow_indexPositive, pow.Eq>(a.pows).SetEquals(
new nilnul.obj.set_.EqDefaulted<Pow_indexPositive, pow.Eq>(b.pows)
			);
		}

		public bool re(Product_ofPositivePow a, Product_ofPositivePow b)
		{
			return _re_assumeSimplified(
				a.asSimplify()
				,
				b.asSimplify()
			);
		}

		public bool Equals(Product_ofPositivePow a, Product_ofPositivePow b)
		{
			return object.ReferenceEquals(a,b) || re(
				a
				,
				b
			);
		}

		public int GetHashCode(Product_ofPositivePow obj)
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
