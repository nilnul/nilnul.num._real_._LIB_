using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaled_
{
	public class Scaled_powIndexPositive
		:
		AlgebraicI

	{
		private pows.Product_ofPositivePow _product;

		public pows.Product_ofPositivePow product
		{
			get { return _product; }
			set { _product = value; }
		}

		private nilnul.num.real.expr_._algebraic.pows.prod._scaled.Coef _coef;

		public nilnul.num.real.expr_._algebraic.pows.prod._scaled.Coef coef
		{
			get { return _coef; }
			set { _coef = value; }
		}

		public Scaled_powIndexPositive(
			nilnul.num.real.expr_._algebraic.pows.prod._scaled.Coef coef
			, pows.Product_ofPositivePow product
			)
		{
			_coef = coef;
			_product = product;
		}
		public Scaled_powIndexPositive(Coef x, VarI y):this(
			x
			,
			new Product_ofPositivePow(y)
		)
		{
		}
		public Scaled_powIndexPositive(RealI realI, Product_ofPositivePow key)
			:this(
				 new Coef(realI)
				 ,
				 key
				)
		{
		}
		public Scaled_powIndexPositive(pows.Product_ofPositivePow product) : this(
			new Coef(1)
			,
			product
		)
		{
		}
		public Scaled_powIndexPositive(Pow_indexPositive product) : this(
			new Product_ofPositivePow(product)
		)
		{
		}


		public Scaled_powIndexPositive(Coef x):this(x, new Product_ofPositivePow())
		{
		}

		public Scaled_powIndexPositive(VarI y):this( new Product_ofPositivePow(y) )
		{
		}
		public Scaled_powIndexPositive(int v, params VarI[] vars):this(
			new Coef(v)

			,
			new Product_ofPositivePow(vars)

		)
		{
		}
		public Scaled_powIndexPositive(int v):this(new Coef(v))
		{
		}
		public Scaled_powIndexPositive() : this(
			new pows.Product_ofPositivePow()
		)
		{
		}

		public bool isNil()
		{
			return this._coef.isNil();
			throw new NotImplementedException();
		}


		public Scaled_powIndexPositive toSimplify()
		{
			if ( _coef.isNil())
			{
				return new Scaled_powIndexPositive(0);
			}
			return new Scaled_powIndexPositive(
				_coef
				,
				_product.toSimplify()
			);
		}

		public override string ToString()
		{
			if (_coef.constant.ToReal()==1)
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
				_coef.expr.ee
				,
				_product.expr.ee
			)
		//basis.sys
		);

		public Scaled_powIndexPositive negate()
		{
			return new Scaled_powIndexPositive(
				this._coef.negate()
				,
				this._product
			);
		}

		static public Scaled_powIndexPositive operator -(Scaled_powIndexPositive x)
		{
			return new Scaled_powIndexPositive(
				- x._coef
				,
				x._product
			);
		}
		static public scaleds.Sum_powIndexPositive operator +(
			Scaled_powIndexPositive x
			,
			Scaled_powIndexPositive y
		)
		{
			return new scaleds.Sum_powIndexPositive (
				 x
				,
				 y
			);
		}
		static public scaleds.Sum_powIndexPositive operator +(
			Product_ofPositivePow x0
			,
			Scaled_powIndexPositive x2
		)
		{
			return new Scaled_powIndexPositive( x0 ) + x2;
		}

		static public scaleds.Sum_powIndexPositive operator +(
			Scaled_powIndexPositive x2
			,
			Product_ofPositivePow x0
		)
		{
			return x2+ new Scaled_powIndexPositive( x0 );
		}

		static public scaleds.Sum_powIndexPositive operator +(
			Scaled_powIndexPositive x
			,
			Pow_indexPositive v)
		{
			return x+ 
				new Product_ofPositivePow(
					v
				)
			;
		}
		static public scaleds.Sum_powIndexPositive operator +(
			Pow_indexPositive x0
			,
			Scaled_powIndexPositive x2
		)
		{
			return new Product_ofPositivePow( x0 ) + x2;
		}

		static public scaleds.Sum_powIndexPositive operator +(
			Scaled_powIndexPositive x
			,
			nilnul.num.real.expr_.VarI v
		)
		{
			return x + new Pow_indexPositive(
				
				v
			);
		}




		static public Scaled_powIndexPositive operator *(Scaled_powIndexPositive x
			,
			Scaled_powIndexPositive y
		)
		{
			return new Scaled_powIndexPositive(
				 x._coef * y._coef
				,
				x._product * y._product
			);
		}

		static public Scaled_powIndexPositive operator *(Scaled_powIndexPositive x
			,
			real.expr_.VarI y
		)
		{
			return new Scaled_powIndexPositive(
				 x._coef 
				,
				x._product * y
			);
		}

		static public Scaled_powIndexPositive operator *(Scaled_powIndexPositive x
			,
			real.expr_._algebraic.pows.prod._scaled.Coef  y
		)
		{
			return new Scaled_powIndexPositive(
				 x._coef *y
				,
				x._product 
			);
		}




	}
}
