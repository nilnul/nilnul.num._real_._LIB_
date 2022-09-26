//using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.pons.prod
{
	public class Scaled

	{
		private Product _product;

		public Product product
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
			RealI coef
			,
			Product product
			)
		{
			_coef = coef;
			_product = product;
		}

		
		public Scaled(
			int v
			,
			Product product_ofPositivePow
		)
			:
			this(new nilnul.num.real_.Quotient(v), product_ofPositivePow)
		{
		}
		
		public Scaled(int v, params VarI[] vars):this(
			v

			,
			new Product(vars)

		)
		{
		}
	
		public Scaled(Product product) : this(
			real_.Quotient.One
			,
			product
		)
		{
		}
		public Scaled(IEnumerable< Ponent> product) : this(
			new Product(product)
		)
		{
		}
		public Scaled(params Ponent[] product) : this(
			new Product(product)
		)
		{
		}
		public Scaled(Ponent product) : this(
			new Product(product)
		)
		{
		}

		public Scaled(Algebraic ponent)
			:this(new Ponent(ponent))
		{
		}


		public Scaled(VarI y):this( new Algebraic(y) )
		{
		}

		public Scaled(RealI x):this(x,  Product.One)
		{
		}

		public Scaled(nilnul.num.real_.Quotient v):this((RealI)(v))
		{
			_simplified = true;
		}
		public Scaled(int v):this( nilnul.num.real_.Quotient.Of(v))
		{
		}


		public Scaled() : this(
			
			0
		)
		{
		}

		public bool isNil()
		{
			return nilnul.num.real.be_.Nil.Singleton.be(this._coef);

		}
		public static readonly Scaled Nil = new Scaled() ;

		public static readonly Scaled One = new Scaled(1);
		public static readonly Scaled NegOne = new Scaled(real_.Quotient.One) {
			
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

				this._product = Product.One;
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

	

		public Scaled asSimplify()
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
				if (_product.ponents.Any())
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





		static public Scaled operator -(Scaled x)
		{
			return new Scaled(
				- x._coef.ToReal()
				,
				x._product
			);
		}
		public Scaled toNegate()
		{
			return -this;
		}

		static public algebraic.pons.prod.scaleds.Sum operator +(
			Scaled x
			,
			Scaled y
		)
		{
			return new scaleds.Sum (
				 x
				,
				 y
			);
		}
		static public scaleds.Sum operator +(
			Product x0
			,
			Scaled x2
		)
		{
			return new Scaled( x0 ) + x2;
		}

		static public scaleds.Sum operator +(
			Scaled x2
			,
			Product x0
		)
		{
			return x2+ new Scaled( x0 );
		}

		static public scaleds.Sum operator +(
			Scaled x
			,
			Ponent v)
		{
			return x
				+ 
				new Product(
					v
				)
			;
		}
		static public scaleds.Sum operator +(
			Ponent x0
			,
			Scaled x2
		)
		{
			return new Product( x0 ) + x2;
		}

		static public scaleds.Sum operator +(
			Scaled x
			,
			nilnul.num.real.expr_.VarI v
		)
		{
			return x + new Ponent(
				
				v
			);
		}




		static public Scaled operator *(
			Scaled x
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
		static public Scaled operator *(
			Scaled x
			,
			Algebraic y
		)
		{
			return new Scaled(
				 x._coef
				,
				x._product * y
			);
		}
		static public Scaled operator *(
			Algebraic y
			,
			Scaled x
		)
		{
			return new Scaled(
				 x._coef
				,
				y*x._product 
			);
		}


		static public Scaled operator *(
			Scaled x
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

		static public Scaled operator *(
			Scaled x
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
		static public Scaled operator *(
			RealI  y
			,
			Scaled x
		)
		{
			return x * y;
		}

		static public Scaled operator *(
			Scaled x
			,
			int  y
		)
		{
			return new Scaled(
				 x._coef.ToReal() *y
				,
				x._product 
			);
		}
		static public Scaled operator *(
			int  y
			,
			Scaled x
		)
		{
			return x * y;
		}






	}
}
