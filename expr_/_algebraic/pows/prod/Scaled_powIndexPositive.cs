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

		private nilnul.num.RealI _coef;

		public nilnul.num.RealI coef
		{
			get { return _coef; }
			set { _coef = value; }
		}

		public Scaled_powIndexPositive(
			RealI coef
			,
			pows.Product_ofPositivePow product
		)
		{
			_coef = coef;
			_product = product;
		}

		
		public Scaled_powIndexPositive(int v,
			Product_ofPositivePow product_ofPositivePow)
			:
			this(new nilnul.num.real_.Quotient(v), product_ofPositivePow)
		{
		}
		
		public Scaled_powIndexPositive(int v, params VarI[] vars):this(
			v

			,
			new Product_ofPositivePow(vars)

		)
		{
		}
	
		public Scaled_powIndexPositive(pows.Product_ofPositivePow product) : this(
			real_.Quotient.One
			,
			product
		)
		{
		}
		public Scaled_powIndexPositive(IEnumerable< Pow_indexPositive> product) : this(
			new Product_ofPositivePow(product)
		)
		{
		}
		public Scaled_powIndexPositive(params Pow_indexPositive[] product) : this(
			new Product_ofPositivePow(product)
		)
		{
		}
		public Scaled_powIndexPositive(Pow_indexPositive product) : this(
			new Product_ofPositivePow(product)
		)
		{
		}


		public Scaled_powIndexPositive(VarI y):this( new Product_ofPositivePow(y) )
		{
		}

		public Scaled_powIndexPositive(RealI x):this(x,  Product_ofPositivePow.One)
		{
		}

		public Scaled_powIndexPositive(nilnul.num.real_.Quotient v):this((RealI)(v))
		{
			_simplified = true;
		}
		public Scaled_powIndexPositive(int v):this( nilnul.num.real_.Quotient.Of(v))
		{
		}


		public Scaled_powIndexPositive() : this(
			
			 pows.Product_ofPositivePow.One
		)
		{
		}


		public bool isNil()
		{
			return nilnul.num.real.be_.Nil.Singleton.be(this._coef);

		}

		public static readonly Scaled_powIndexPositive One = new Scaled_powIndexPositive() { };
		public static readonly Scaled_powIndexPositive NegOne = new Scaled_powIndexPositive(real_.Quotient.One) {
			
		};

		public void simplify()
		{
			if (_simplified)
			{
				return;
			}
			if ( isNil())
			{
				/* don't do this, as this might be reused in other objects
				/// this._product.clear();
				*/

				this._product = Product_ofPositivePow.One;
				if (! (this._coef is nilnul.num.real_.Quotient ))
				{
					this._coef = nilnul.num.real_.Quotient.Nil;

				}
				_simplified = true;
				return;
			}
			this._product.simplify();
			_simplified = true;


			
		}

		public Scaled_powIndexPositive toSimplify()
		{
			return asSimplify();
		}

		public Scaled_powIndexPositive asSimplify()
		{
			simplify();
			return this;
			
		}
		private bool _simplified;


		public override string ToString()
		{
			var coefAsClass = _coef.ToReal();
			if (coefAsClass==1)//to show one, we might treat this as two algebraic multipled: 1 * Product
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
			if (coefAsClass ==-1)
			{
				
				return $"-{_product}";
			}
			return $"{_coef} {_product}";
			//if coef is nil, the whole of this would be eliminated by caller.
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

		public Scaled_powIndexPositive negate()
		{
			return new Scaled_powIndexPositive(
				-this._coef.ToReal()
				,
				this._product
			);
		}

		static public Scaled_powIndexPositive operator -(Scaled_powIndexPositive x)
		{
			return new Scaled_powIndexPositive(
				- x._coef.ToReal()
				,
				x._product
			);
		}
		static public Algebraic operator +(
			Scaled_powIndexPositive x
			,
			Scaled_powIndexPositive y
		)
		{
			return new Algebraic (
				 x
				,
				 y
			);
		}
		static public Algebraic operator +(
			Product_ofPositivePow x0
			,
			Scaled_powIndexPositive x2
		)
		{
			return new Scaled_powIndexPositive( x0 ) + x2;
		}

		static public Algebraic operator +(
			Scaled_powIndexPositive x2
			,
			Product_ofPositivePow x0
		)
		{
			return x2+ new Scaled_powIndexPositive( x0 );
		}

		static public Algebraic operator +(
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
		static public Algebraic operator +(
			Pow_indexPositive x0
			,
			Scaled_powIndexPositive x2
		)
		{
			return new Product_ofPositivePow( x0 ) + x2;
		}

		static public Algebraic operator +(
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
				 x._coef.ToReal() * y._coef
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
			RealI  y
		)
		{
			return new Scaled_powIndexPositive(
				 x._coef.ToReal() *y
				,
				x._product 
			);
		}
		static public Scaled_powIndexPositive operator *(
			RealI  y
			,
			Scaled_powIndexPositive x
		)
		{
			return x * y;
		}

		static public Scaled_powIndexPositive operator *(Scaled_powIndexPositive x
			,
			int  y
		)
		{
			return new Scaled_powIndexPositive(
				 x._coef.ToReal() *y
				,
				x._product 
			);
		}
		static public Scaled_powIndexPositive operator *(
			int  y
			,
			Scaled_powIndexPositive x
		)
		{
			return x * y;
		}






	}
}
