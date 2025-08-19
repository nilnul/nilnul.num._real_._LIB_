using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.re_
{
	/// <summary>
	/// x is multiplic of y if x can be divided by y
	/// </summary>
	public class Multiplic
		:
		nilnul.rel._has.re_.net_.PosetI<
			Product_ofPositivePow
		>
		
	{
		public BigInteger _Index(Product_ofPositivePow a, ParameterExpression b)
		{
			
			return  a.pows.Where(
				p=> nilnul.obj.expr_.var.Eq.Singleton.Equals( p.basis.sys,b)
			).Select(n=>n.index.en)
			.FirstOrDefault()
			;
		}
		public bool _re_assumeSimplified(Product_ofPositivePow a, Product_ofPositivePow b)
		{
			return new nilnul.obj.expr_.var.SetOfVars(
				 a.pows.Select(
					p => p.basis.sys
				).Concat(
					b.pows.Select(p1 => p1.basis.sys)
				)
			).All(
				v=> _Index(a, v) >= _Index(b, v)
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

	

		static public Multiplic Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Multiplic>.Instance;
			}
		}

	}
}
