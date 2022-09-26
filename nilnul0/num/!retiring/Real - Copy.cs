using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using Qq = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;

namespace nilnul.num
{

	
	/// <summary>
	/// Wrap a real with operators
	/// </summary>
	/// 
	[Obsolete()]
	public class Real
		: nilnul.obj.Box<R>
		,
		R
	{
		
		public Real(R v):base(v)
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

		public  Real poly( N n) {
			return nilnul.num.real.op_.Poly.Singleton.eval(this, n).ToReal();
		}

		public static Real Div(int v, R diameter)
		{
			return  nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(v, diameter).ToReal();

			throw new NotImplementedException();
		}

		

		public Real sqrt() {
			return nilnul.num.real_.nonneg.op_.Sqrt.Singleton.eval( this.boxed).ToReal();
		}

		
		static public implicit operator Real(real_.Quotient q) {
			return new Real(q);
		}

		static public implicit operator Real(Qq q) {
			return new nilnul.num.real_.Quotient(q);
		}


		static public implicit operator Real(int q) {
			return new Real((real_.Quotient) q);
		}




		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public Real operator +(Real a, Real b) {
			return new Real( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}

		static public Real operator +(Real a, R b) {
			return new Real( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}


		static public Real operator -(Real a, Real b) {
			return new Real( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}

		static public Real operator -(R  a, Real b) {
			return new Real( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public Real operator -(Real  a, R b) {
			return new Real( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public Real operator -(Real  a ) {
			return new Real( nilnul.num.real.op_.Negate.lazy.eval(a));
		}

		static public bool operator <=(Real a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, b);
		}
		static public bool operator <(Real a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(R  a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(Real  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a.boxed, b);
		}

		static public Real Sqrt(Real a) {
			return nilnul.num.real.op_.Sqrt.Singleton.eval(a).ToReal();
		}
		static public Real Sqrt(R a) {
			return nilnul.num.real.op_.Sqrt.Singleton.eval(a).ToReal();
		}
		static public Real Squar(R a) {
			return nilnul.num.real.op_.Square.Singleton.eval(a).ToReal();
		}

		static public bool operator >(Real a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}

		static public bool operator >(Real a, int b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator <(Real a, int b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator >=(Real a, int b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, new nilnul.num.real_.Quotient( b) );
		}
		static public bool operator <=(Real a, int b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator ==(Real a, int b) {
			return nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator !=(Real a, int b) {
			return !nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}


		static public bool operator >(Real a, long b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator <(Real a, long b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator >=(Real a, long b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, new nilnul.num.real_.Quotient( b) );
		}
		static public bool operator <=(Real a, long b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator ==(Real a, long b) {
			return nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator !=(Real a, long b) {
			return !nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator >(Real a, ulong b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator <(Real a, ulong b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator >=(Real a, ulong b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, new nilnul.num.real_.Quotient( b) );
		}
		static public bool operator <=(Real a, ulong b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator ==(Real a, ulong b) {
			return nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator !=(Real a, ulong b) {
			return !nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}


		static public bool operator >(Real a, BigInteger b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator <(Real a, BigInteger b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator >=(Real a, BigInteger b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, new nilnul.num.real_.Quotient( b) );
		}
		static public bool operator <=(Real a, BigInteger b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator ==(Real a, BigInteger b) {
			return nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}

		static public bool operator !=(Real a, BigInteger b) {
			return !nilnul.num.real.Eq1.Singleton.Equals(a, new nilnul.num.real_.Quotient( b) );
		}




		static public bool operator >(int b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator <(int b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator >=( int b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge( new nilnul.num.real_.Quotient( b) , c);
		}
		static public bool operator <=( int b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.le( new nilnul.num.real_.Quotient( b),c );
		}

		static public bool operator ==( int b, Real c) {
			return nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator !=( int b, Real c) {
			return !nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}


	static public bool operator >(long b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator <(long b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator >=( long b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge( new nilnul.num.real_.Quotient( b) , c);
		}
		static public bool operator <=( long b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.le( new nilnul.num.real_.Quotient( b),c );
		}

		static public bool operator ==( long b, Real c) {
			return nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator !=( long b, Real c) {
			return !nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}


	static public bool operator >(ulong b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator <(ulong b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator >=( ulong b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge( new nilnul.num.real_.Quotient( b) , c);
		}
		static public bool operator <=( ulong b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.le( new nilnul.num.real_.Quotient( b),c );
		}

		static public bool operator ==( ulong b, Real c) {
			return nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator !=( ulong b, Real c) {
			return !nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}

	static public bool operator >(BigInteger b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator <(BigInteger b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator >=( BigInteger b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge( new nilnul.num.real_.Quotient( b) , c);
		}
		static public bool operator <=( BigInteger b,Real c) {
			return nilnul.num.real.Comparer.Decider.Singleton.le( new nilnul.num.real_.Quotient( b),c );
		}

		static public bool operator ==( BigInteger b, Real c) {
			return nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}

		static public bool operator !=( BigInteger b, Real c) {
			return !nilnul.num.real.Eq1.Singleton.Equals( new nilnul.num.real_.Quotient( b) ,c);
		}



		static public bool operator >(R  a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}
		static public bool operator >(Real  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a.boxed, b);
		}

		static public bool operator >=(Real a, Real b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, b);
		}

		static public Real operator *(Real a, Real b) {
			return new Real( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}

		static public Real operator *(R a, Real b) {
			return new Real( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}
		static public Real operator *(Real a, R b) {
			return new Real( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}

		static public Real operator /(Real a, Real b) {
			return new Real( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public Real operator /(Real a, N b) {
			return new Real( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public Real operator /(R a, Real b) {
			return new Real( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}
		static public Real operator /(Real a, R b) {
			return new Real( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public Real operator /(Qq a, Real b) {
			return new Real( 
				nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(
					a
					, 
				
					b.boxed
				)
			);
		}




		static public Real operator *(Qq a, Real b) {
			return new Real( 
				
				nilnul.num.real.op_._ScaleX.Scale(a, b)
				
				);
		}

	


		static public Real CreateOne() {
			return 1;
		}

		static public Real CreateZero() { return 0; }
		
	}
}
