using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using Qq = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.be.Natural.Asserted;
namespace nilnul.num.real.all
{
	/// <summary>
	/// box or wrap a real with operators
	/// </summary>
	public class RealB
		: nilnul.Box1<R>
		 
	{
		
		public RealB(R v):base(v)
		{

		}
		public GeneratorI choice
		{
			get
			{
				return boxed.choice;
				//throw new NotImplementedException();
			}
		}

		public  RealB poly( N n) {
			return nilnul.num.real.op_.Poly.Singleton.eval(this, n).ToX();
		}

		public static RealB Div(int v, R diameter)
		{
			return  nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(v, diameter).ToX();

			throw new NotImplementedException();
		}

		public RealB sqrt() {
			return nilnul.num.real_.nonNeg.op_.Sqrt.Singleton.eval( this.boxed).ToX();
		}

		
		static public implicit operator RealB(real_.Quotient q) {
			return new RealB(q);
		}

		static public implicit operator RealB(Qq q) {
			return new nilnul.num.real_.Quotient(q);
		}


		static public implicit operator RealB(int q) {
			return new RealB((real_.Quotient) q);
		}




		//this will not compile
		//static public implicit operator RealB(R q)
		//{
		//	return new RealB(q);
		//}

		static public RealB operator +(RealB a, RealB b) {
			return new RealB( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}

		static public RealB operator +(RealB a, R b) {
			return new RealB( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}


		static public RealB operator -(RealB a, RealB b) {
			return new RealB( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}

		static public RealB operator -(R  a, RealB b) {
			return new RealB( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public RealB operator -(RealB  a, R b) {
			return new RealB( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public RealB operator -(RealB  a ) {
			return new RealB( nilnul.num.real.op_.Negate.lazy.eval(a));
		}

		static public bool operator <=(RealB a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, b);
		}
		static public bool operator <(RealB a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(R  a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(RealB  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a.boxed, b);
		}

		static public bool operator >(RealB a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}
		static public bool operator >(R  a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}
		static public bool operator >(RealB  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a.boxed, b);
		}

		static public bool operator >=(RealB a, RealB b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, b);
		}

		static public RealB operator *(RealB a, RealB b) {
			return new RealB( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}
		static public RealB operator /(RealB a, RealB b) {
			return new RealB( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealB operator /(RealB a, N b) {
			return new RealB( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealB operator /(R a, RealB b) {
			return new RealB( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}
		static public RealB operator /(RealB a, R b) {
			return new RealB( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealB operator /(Qq a, RealB b) {
			return new RealB( 
				nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(
					a
					, 
				
					b.boxed
				)
			);
		}




		static public RealB operator *(Qq a, RealB b) {
			return new RealB( 
				
				nilnul.num.real.op_._ScaleX.Scale(a, b)
				
				);
		}

	


		static public RealB CreateOne() {
			return 1;
		}

		static public RealB CreateZero() { return 0; }
		
	}
}
