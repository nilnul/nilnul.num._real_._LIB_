//using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.pows.prod
{
	public class Scaled
		:
		FracI

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

		public Scaled(
			nilnul.num.RealI coef
			, pows.Product product
			)
		{
			_coef = coef;
			_product = product;
		}
		public Scaled(
			nilnul.num.RealI coef
		):this(coef, new Product())
		{
		}

		public Scaled(
			int coef
			, pows.Product product
		)
			:this(
				 new nilnul.num.real_.Quotient(coef)
				 ,
				 product
			)
		{
			
		}

		public Scaled(num.RealI x, VarI y):this(
			x
			,
			new Product(y)
		)
		{
		}

		public Scaled(int x, VarI y):this(
			new nilnul.num.real_.Quotient(
				x
			)
			,
			new Product(y)
		)
		{
		}
		
		public Scaled(pows.Product product) : this(
			1
			,
			product
		)
		{
		}
		public Scaled(Pow product) : this(
			new Product(product)
		)
		{
		}


		public Scaled(int x):this(x, new Product())
		{
		}

		public Scaled(VarI y):this( new Product(y) )
		{
		}
		public Scaled(int v, params VarI[] vars):this(
			(v)

			,
			new Product(vars)

		)
		{
		}
		//public Scaled(int v):this(new nilnul.num.real_.Quotient(v))
		//{
		//}
		public Scaled() : this(
			1
		)
		{
		}

		public bool isNil()
		{
			return nilnul.num.real.be_.Nil.Singleton.be(this.coef);
			//throw new NotImplementedException();
		}

		public Scaled toSimplify()
		{
			if ( isNil())
			{
				return new Scaled(0);
			}
			return new Scaled(
				_coef
				,
				_product.toSimplify()
			);
		}

		public override string ToString()
		{
			if (_coef.ToReal()==1)
			{
				if (_product.pows.Any())
				{
					return $"{_product}";
				}
				//else
				//{
				//	return "1";
				//}
			}
			return $"{_coef} {_product}";
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
					new[] { typeof(num.RealI), typeof(num.RealI) }
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

		public Scaled toNegate()
		{
			return new Scaled(
				-this._coef.ToReal()
				,
				this._product
			);
		}

		static public Scaled operator -(Scaled x)
		{
			return x.toNegate();
		}
		static public Scaled operator *(Scaled x
			,
			Scaled y
		)
		{
			return new Scaled(
				 x._coef.ToReal() * y._coef
				,
				x._product * y._product
			);
		}

		static public Scaled operator *(Scaled x
			,
			real.expr_.VarI y
		)
		{
			return new Scaled(
				 x._coef 
				,
				x._product * y
			);
		}

		static public Scaled operator *(Scaled x
			,
			RealI  y
		)
		{
			return new Scaled(
				 x._coef.ToReal() *y
				,
				x._product 
			);
		}




	}
}
