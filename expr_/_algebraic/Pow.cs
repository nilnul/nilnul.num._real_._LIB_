using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic
{
	public class Pow
		:
		nilnul.obj.Box1<
			nilnul.num.real.expr_.VarI
		>
		,
		AlgebraicI
	{
		private nilnul.NumI1 _index;

		/// <summary>
		/// if index is nil, this can be transformed to 1.
		/// </summary>
		public nilnul.NumI1 index
		{
			get { return _index; }
			set { _index = value; }
		}


		public nilnul.num.real.expr_.VarI	basis
		{
			get { return boxed; }
		}

		public Ee<RealI> generi => new Ee<RealI>(this);

		public Ee expr => new Ee(
			System.Linq.Expressions.MethodCallExpression.Call(
				typeof(real.op_.unary_._PolyX).GetMethod(
					nameof(
						real.op_.unary_._PolyX.RealI
					)
					,
					new[] { typeof(num.RealI), typeof(NumI1)}
				)
				,
				basis.sys
				,
				Expression.Constant(
					index
				)
			)
			//basis.sys
		);

		public Pow(
			VarI val
			,
			nilnul.NumI1 index
		) : base(val)
		{
			_index = index;
		}

		public override string ToString()
		{
			return $"{this.boxed}^{this._index}";
		}


	}
}
