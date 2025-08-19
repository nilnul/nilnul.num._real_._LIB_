//using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod
{
	public class Scaled
		:
		AlgebraicI
	{
		private pows.Product _product;

		public pows.Product product
		{
			get { return _product; }
			set { _product = value; }
		}

		private nilnul.num.RealI _coef;

		public nilnul.num.RealI coef
		{
			get { return _coef; }
			set { _coef = value; }
		}

		public Scaled(nilnul.num.RealI  coef,pows.Product product)
		{
			_coef = coef;
			_product = product;
		}
		public Scaled(int  coef,pows.Product product)
			:
			this(new nilnul.num.real_.Quotient(1),product)
		{
		}

		public Scaled(pows.Product product):this(
			(1)
			,
			product
		)
		{
		}
		public Scaled():this(
			new pows.Product()
		)
		{
		}

		public override string ToString()
		{
			return $"{_coef}{_product}";
		}

		public Scaled negate() {
			return new Scaled(
				-this._coef.ToReal()
				,
				this._product
			);
		}

		public Ee<RealI> generi => new Ee<RealI>(this);

		public Ee expr => new Ee(

			System.Linq.Expressions.MethodCallExpression.Call(
				Expression.Constant(
real.op_.binary_.Multi.Singleton
					)
				,
				typeof(real.op_.binary_.Multi).GetMethod(
					nameof(
						real.op_.binary_.Multi.Singleton.op
					)
					,
					new[] { typeof(num.RealI), typeof(num.RealI)}
				)
				,
				Expression.Constant(
				_coef
				)
				,
				_product.expr.ee
			)
		//basis.sys
		);
	}
}
