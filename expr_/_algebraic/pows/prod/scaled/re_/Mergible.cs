using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaled.re_
{
	/// <summary>
	/// only different at coef
	/// </summary>
	public class Mergible
		:
		nilnul.obj.ReI<
			Scaled_powIndexPositive
		>

	{
		public bool _re_assumeSimplified(Product_ofPositivePow a, Product_ofPositivePow b)
		{
			return new nilnul.obj.set_.EqDefaulted<Pow_indexPositive, pow.Eq>(a.pows).SetEquals(
new nilnul.obj.set_.EqDefaulted<Pow_indexPositive, pow.Eq>(b.pows)
			);
		}

		public bool _re_assumeSimplified(Scaled_powIndexPositive scaled_powIndexPositive1, Scaled_powIndexPositive scaled_powIndexPositive2)
		{

			return _algebraic.pows.prod.Eq.Singleton.Equals(
				scaled_powIndexPositive1.product
				,
				scaled_powIndexPositive2.product
			);
		}
	
		public bool re(Scaled_powIndexPositive a, Scaled_powIndexPositive b)
		{
			return object.ReferenceEquals(a,b) || _re_assumeSimplified(
				a.asSimplify()
				,
				b.asSimplify()
			);

		}


		static public Mergible Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Mergible>.Instance;
			}
		}

	}
}
