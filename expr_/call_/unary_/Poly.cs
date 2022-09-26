using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.num.real.ExprI;

namespace nilnul.num.real.expr_.call_.unary_
{
	public class Poly
		:E
	{
		private E _basis;

		public E basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private nilnul.NumI1 _index;

		public nilnul.NumI1 index
		{
			get { return _index; }
			set { _index = value; }
		}

		public var.Set vars =>_basis.vars;

		public Poly(
			E basis
			,
			nilnul.NumI1 index

			)
		{
			_basis = basis;
			_index = index;
		}

		public Poly(E expr, int i):this(
			expr,new nilnul.Num1(i)
		)
		{
		}

		public E substitute(real.VarI var, E expr)
		{
			return new Poly(
				basis.substitute(var, expr)
				,
				index
			);
		}
	}
}
