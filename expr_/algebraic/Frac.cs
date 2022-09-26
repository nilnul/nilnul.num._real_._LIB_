using nilnul.num.real.expr_._algebraic.pows.prod.scaleds;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic
//_.pows.prod.scaleds.sum
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		quotient
	///		,
	///		frac
	///		,
	///		rational
	public class Frac
		:FracI
	{
		private Algebraic _numerator;

		public Algebraic numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}

		private Algebraic _denominator;

		public Algebraic denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}


		public Frac(
			Algebraic numerator
						,
			Algebraic denominator
		)
		{
			this._numerator = numerator;
			this._denominator = denominator;
		}
		public Frac(
			Algebraic numerator
			
		):this(
			numerator
			,
			 Algebraic.One
		)
		{
		}
		public Frac(
			num.real.expr_.VarI var
		):this(
			new Algebraic(var)
		)
		{

		}

		public Frac(int i):this(new Algebraic(i))
		{

		}
		public Frac():this(
			 Algebraic.Nil
		)
		{

		}

		public Frac(int v, Algebraic denominator)
			:this(
				 new Algebraic(v)
				 ,
				 denominator
			)
		{
		}

		public Ee<RealI> generi => new Ee<RealI>(this);

		public Ee expr => new Ee(
			System.Linq.Expressions.MethodCallExpression.Call(
				Expression.Constant(
real.op_.binary_.Divide.Singleton
					)
				,
				typeof(real.op_.binary_.Divide).GetMethod(
					nameof(
						real.op_.binary_.Divide.Singleton.op
					)
					,
					new[] { typeof(num.RealI), typeof(num.RealI)}
				)
				,
				this._numerator.expr
				,
				this._denominator.expr
			)
		);

		static public Frac operator -(Frac x) {
			return new Frac(
				-x.numerator
				,
				x._denominator
			);
		}
		static public Frac operator +(Frac x,Frac y) {
			if (x._denominator == y._denominator)
			{
				return new Frac(
					x._numerator+y._numerator
					,
					x._denominator
				);

			}

			return new Frac(
				x._numerator*y.denominator + x.denominator *y.numerator
				,
				x._denominator*y._denominator
			);
		}
		static public Frac operator +(Frac x, Algebraic y)
		{
			
			return new Frac(
				x._numerator  + x.denominator * y
				,
				x._denominator 
			);
		}
		static public Frac operator +(Frac x, int y)
		{
			
			return new Frac(
				x._numerator  + x.denominator * y
				,
				x._denominator 
			);
		}
		static public Frac operator +(int x, Frac y)
		{
			
			return new Frac(
				x * y._denominator
				+
				y._numerator 
				,
				y._denominator 
			);
		}


		static public Frac operator +( Algebraic y, Frac x)
		{
			
			return new Frac(y*
				x.denominator  +
				x._numerator   
				,
				x._denominator 
			);
		}


		static public Frac operator -(Frac x,Frac y) {
			return x+ (-y);
		}

		static public Frac operator -(Frac x,Algebraic y) {
			return x+ (-y);
		}
		static public Frac operator -(Algebraic y, Frac x) {
			return y + -x;
		}
		static public Frac operator -(Frac x,int y) {
			return x+ (-y);
		}

		static public Frac operator -(int a, Frac x) {
			return a+ (-x);
		}


		static public bool operator ==(Frac x,Frac y) {
			return (x-y).isNil();
		}
		static public bool operator !=(Frac x,Frac y) {
			return !(x==y);
		}

		static public bool operator ==(Frac x,Algebraic y) {
			return (x-y).isNil();
		}
		static public bool operator !=(Frac x,Algebraic y) {
			return !(x==y);
		}
		static public bool operator ==(Algebraic x0,Frac y) {
			return y==x0;
		}
		static public bool operator !=(Algebraic a, Frac x) {
			return !(a==x);
		}


		public bool isNil()
		{
			return !this._denominator.isNil() && this._numerator.isNil();
		}


		static public Frac operator *(Frac x,Frac y) {
			return new Frac(
				x._numerator*y.numerator
				,
				x._denominator*y._denominator
			);
		}
		static public Frac operator *(int x,Frac y) {
			return new Frac(
				x*y.numerator
				,
				y._denominator
			);
		}

		static public Frac operator *(Frac y,int x) {
			return new Frac(
				y.numerator*x
				,
				y._denominator
			);
		}
		static public Frac operator *(Frac y,Algebraic x) {
			return new Frac(
				y.numerator*x
				,
				y._denominator
			);
		}

		static public Frac operator *(Algebraic x , Frac y) {
			return new Frac(
				x * y._numerator
				,
				y._denominator
			);
		}



		public Frac toInverse() {
			return new Frac(_denominator,_numerator);
		}

		public void simplify() {
			
			if (_numerator.isNil())
			{
				if (!object.ReferenceEquals( _numerator, Algebraic.Nil))
				{
					_numerator = Algebraic.Nil;
				}
				if (!object.ReferenceEquals( _denominator, Algebraic.One))
				{
					_denominator = Algebraic.One;
				}
				return;
			}

			_denominator.simplify();
			
		}

		public Frac asSimplify() {
			simplify();
			return this;
		}


		public override string ToString()
		{
			var numeratorTxt = _numerator.ToString();
			if (_numerator.scaleds.Count()>=2)
			{
				numeratorTxt = $"({numeratorTxt})";
			}
			var denominatorTxt = _denominator.ToString();
			if (_denominator.scaleds.Count()>=2)
			{
				denominatorTxt = $"({denominatorTxt})";
			}
			if (denominatorTxt=="1")
			{
				return $"{numeratorTxt}";
			}

			return $"{numeratorTxt}/{denominatorTxt}";
		}

		public static readonly Frac Nil = new Frac();

		static public Frac operator /(Frac x,Frac y) {
			return x*y.toInverse();
		}
		static public Frac operator /(Frac x,Algebraic y) {
			return new Frac(
				x._numerator*y
				,
				x._denominator
			);
		}

		static public Frac operator /(Algebraic x, Frac y) {
			return x * y.toInverse();
		}


		static public Frac Inverse(
			expr_.Algebraic denominator
		) {
			return new Frac(1, denominator);
		}





	}
}
