using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaled.re_
{
	/// <summary>
	/// x is multiplic of y if x's product can be divided by y's product
	/// </summary>
	public class Multiplic
		:
		nilnul.rel._has.re_.net_.PosetI<
			Scaled_powIndexPositive
		>
		
	{

		public bool re(Scaled_powIndexPositive a, Scaled_powIndexPositive b)
		{
			return prod.re_.Multiplic.Singleton.re(
				a.product
				,
				b.product
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
