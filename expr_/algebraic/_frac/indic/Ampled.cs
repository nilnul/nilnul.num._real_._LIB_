//using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.num.real.expr_.algebraic._frac.Pow;

namespace nilnul.num.real.expr_.algebraic._frac.indic
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		scaled
	///		amplified
	public class Ampled
		:
		FracI

	{
		private _frac.Pow _indic;

		public P indic
		{
			get { return _indic; }
			set { _indic = value; }
		}

		private nilnul.num.RealI _coef;

		public nilnul.num.RealI coef
		{
			get { return _coef; }
			set { _coef = value; }
		}

		public Ampled(
			nilnul.num.RealI coef
			,
			P product
		)
		{
			_coef = coef;
			_indic = product;
		}
		public Ampled(
			nilnul.num.RealI coef
			,
			nilnul.num.real.expr_.VarI var
		):this(coef, new P(var))
		{
		}

		public Ampled(
			int coef
			, P product
		)
			:this(
				 new nilnul.num.real_.Quotient(coef)
				 ,
				 product
			)
		{
			
		}

		

		public Ampled(int x, VarI y):this(
			new nilnul.num.real_.Quotient(
				x
			)
			,
			new P(y)
		)
		{
		}
		
		public Ampled(P product) : this(
			1
			,
			product
		)
		{
		}
	



		public Ampled(VarI y):this( new P(y) )
		{
		}
	
	

		public bool isNil()
		{
			return nilnul.num.real.be_.Nil.Singleton.be(this.coef);
		}


		public Ampled toSimplify()
		{
			if ( isNil())
			{
				return new Ampled(0, new P(this._indic.basis,0));
			}
			return this;
		}

		public override string ToString()
		{
			if (isNil())
			{
				return "0";
			}

			if (_coef.ToReal()==1)
			{

				return $"{_indic}";

			}

			return $"{_coef} {_indic}";
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
				_indic.expr.ee
			)
		//basis.sys
		);

		public Ampled toNegate()
		{
			return new Ampled(
				-this._coef.ToReal()
				,
				this._indic
			);
		}

		static public Ampled operator -(Ampled x)
		{
			return x.toNegate();
		}
		static public pows.prod.Scaled operator *(
			Ampled x
			,
			Ampled y
		)
		{
			return new pows.prod.Scaled(
				 x._coef.ToReal() * y._coef
				,
				x._indic * y._indic
			);
		}

		static public pows.prod.Scaled operator *(
			Ampled x
			,
			real.expr_.VarI y
		)
		{
			return new pows.prod.Scaled(
				 x._coef 
				,
				x._indic * y
			);
		}

		static public Ampled operator *(
			Ampled x
			,
			RealI  y
		)
		{
			return new Ampled(
				 x._coef.ToReal() *y
				,
				x._indic 
			);
		}




	}
}
