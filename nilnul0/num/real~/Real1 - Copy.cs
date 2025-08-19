using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI3;
using Q1 = nilnul.num.Quotient1;
using N = nilnul.NumI;
using System.Numerics;
using nilnul.num.quotient.stream_.cauchy.sed.be_.cofinal.vow;

namespace nilnul.num
{

	
	/// <summary>
	/// Wrap a real with operators
	/// </summary>
	/// 
	[Obsolete()]
	public class Real1
		: nilnul.obj.Box<R>
		,
		R
	{
		public R boxed { get { return base.boxed; } }
		
		public Real1(R v):base(v)
		{

		}
		public nilnul.num._real.CauchyI2 choice
		{
			get
			{
				return boxed.choice;
				//throw new NotImplementedException();
			}
		}

		//public En cofinal => boxed.cofinal;

		//public  Real1 poly( N n) {
		//	return nilnul.num.real.op_.Poly.Singleton.eval(this, n).ToReal();
		//}

		//public static Real1 Div(int v, R diameter)
		//{
		//	return  nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(v, diameter).ToReal();

		//	throw new NotImplementedException();
		//}

		

		//public Real1 sqrt() {
		//	return nilnul.num.real_.nonNeg.op_.Sqrt.Singleton.eval( this.boxed).ToReal();
		//}

		
		static public implicit operator Real1(real_.Quotient1 q) {
			return new Real1(q);
		}

		static public implicit operator Real1(Q1 q) {
			return new nilnul.num.real_.Quotient1(q);
		}


		static public implicit operator Real1(int q) {
			return new Real1((real_.Quotient1) q);
		}




		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public Real1 operator +(Real1 a, Real1 b) {
			return new Real1( nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real1 operator +(Real1 a, R b) {
			return new Real1( nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}


		static public Real1 operator -(Real1 a, Real1 b) {
			return new Real1( nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}

		static public Real1 operator -(R  a, Real1 b) {
			return new Real1( nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real1 operator -(Real1  a, R b) {
			return new Real1( nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real1 operator -(Real1  a ) {
			return new Real1( nilnul.num.real.op_.unary_.Neg.lazy.op(a));
		}

		static public bool operator <=(Real1 a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.le(a, b);
		}
		static public bool operator <(Real1 a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, b);
		}
		static public bool operator <(R  a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, b);
		}
		static public bool operator <(Real1  a, R  b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a.boxed, b);
		}



		static public bool operator >(Real1 a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, b);
		}

		static public bool operator >(Real1 a, int b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator <(Real1 a, int b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator >=(Real1 a, int b) {
			return nilnul.num.real.comp.Re1.Singleton.ge(a, new nilnul.num.real_.Quotient1( b) );
		}
		static public bool operator <=(Real1 a, int b) {
			return nilnul.num.real.comp.Re1.Singleton.le(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator ==(Real1 a, int b) {
			return nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator !=(Real1 a, int b) {
			return !nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}


		static public bool operator >(Real1 a, long b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator <(Real1 a, long b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator >=(Real1 a, long b) {
			return nilnul.num.real.comp.Re1.Singleton.ge(a, new nilnul.num.real_.Quotient1( b) );
		}
		static public bool operator <=(Real1 a, long b) {
			return nilnul.num.real.comp.Re1.Singleton.le(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator ==(Real1 a, long b) {
			return nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator !=(Real1 a, long b) {
			return !nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator >(Real1 a, ulong b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator <(Real1 a, ulong b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator >=(Real1 a, ulong b) {
			return nilnul.num.real.comp.Re1.Singleton.ge(a, new nilnul.num.real_.Quotient1( b) );
		}
		static public bool operator <=(Real1 a, ulong b) {
			return nilnul.num.real.comp.Re1.Singleton.le(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator ==(Real1 a, ulong b) {
			return nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator !=(Real1 a, ulong b) {
			return !nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}


		static public bool operator >(Real1 a, BigInteger b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator <(Real1 a, BigInteger b) {
			return nilnul.num.real.comp.Re1.Singleton.lt(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator >=(Real1 a, BigInteger b) {
			return nilnul.num.real.comp.Re1.Singleton.ge(a, new nilnul.num.real_.Quotient1( b) );
		}
		static public bool operator <=(Real1 a, BigInteger b) {
			return nilnul.num.real.comp.Re1.Singleton.le(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator ==(Real1 a, BigInteger b) {
			return nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}

		static public bool operator !=(Real1 a, BigInteger b) {
			return !nilnul.num.real.Eq2.Singleton.Equals(a, new nilnul.num.real_.Quotient1( b) );
		}




		static public bool operator >(int b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.gt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator <(int b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.lt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator >=( int b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.ge( new nilnul.num.real_.Quotient1( b) , c);
		}
		static public bool operator <=( int b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.le( new nilnul.num.real_.Quotient1( b),c );
		}

		static public bool operator ==( int b, Real1 c) {
			return nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator !=( int b, Real1 c) {
			return !nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}


	static public bool operator >(long b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.gt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator <(long b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.lt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator >=( long b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.ge( new nilnul.num.real_.Quotient1( b) , c);
		}
		static public bool operator <=( long b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.le( new nilnul.num.real_.Quotient1( b),c );
		}

		static public bool operator ==( long b, Real1 c) {
			return nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator !=( long b, Real1 c) {
			return !nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}


	static public bool operator >(ulong b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.gt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator <(ulong b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.lt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator >=( ulong b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.ge( new nilnul.num.real_.Quotient1( b) , c);
		}
		static public bool operator <=( ulong b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.le( new nilnul.num.real_.Quotient1( b),c );
		}

		static public bool operator ==( ulong b, Real1 c) {
			return nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator !=( ulong b, Real1 c) {
			return !nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}

	static public bool operator >(BigInteger b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.gt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator <(BigInteger b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.lt( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator >=( BigInteger b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.ge( new nilnul.num.real_.Quotient1( b) , c);
		}
		static public bool operator <=( BigInteger b,Real1 c) {
			return nilnul.num.real.comp.Re1.Singleton.le( new nilnul.num.real_.Quotient1( b),c );
		}

		static public bool operator ==( BigInteger b, Real1 c) {
			return nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}

		static public bool operator !=( BigInteger b, Real1 c) {
			return !nilnul.num.real.Eq2.Singleton.Equals( new nilnul.num.real_.Quotient1( b) ,c);
		}



		static public bool operator >(R  a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a, b);
		}
		static public bool operator >(Real1  a, R  b) {
			return nilnul.num.real.comp.Re1.Singleton.gt(a.boxed, b);
		}

		static public bool operator >=(Real1 a, Real1 b) {
			return nilnul.num.real.comp.Re1.Singleton.ge(a, b);
		}

		static public Real1 operator *(Real1 a, Real1 b) {
			return new Real1( nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}

		static public Real1 operator *(R a, Real1 b) {
			return new Real1( nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}
		static public Real1 operator *(Real1 a, R b) {
			return new Real1( nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}

		static public Real1 operator /(Real1 a, Real1 b) {
			return new Real1( nilnul.num.real.duo_.divisible.bind_._DivX.Bind(a, b));
		}

		static public Real1 operator /(Real1 a, N b) {
			return new Real1( nilnul.num.real.duo_.divisible.bind_._DivX.Bind(a, b));
		}

		static public Real1 operator /(R a, Real1 b) {
			return new Real1( nilnul.num.real.duo_.divisible.bind_._DivX.Bind(a, b));
		}
		static public Real1 operator /(Real1 a, R b) {
			return new Real1( nilnul.num.real.duo_.divisible.bind_._DivX.Bind(a, b));
		}

		static public Real1 operator /(Q1 a, Real1 b) {
			return new Real1( 
				nilnul.num.real.duo_.divisible.bind_._DivX.Bind(
					a
					, 
				
					b
				)
			);
		}

		static public Real1 operator *(Q1 a, Real1 b) {
			return new Real1( 
				nilnul.num.real.op_.unary_._ScaleX.Scale(a, b)
				);
		}

		static public Real1 CreateOne() {
			return 1;
		}

		static public Real1 CreateZero() { return 0; }
		
	}
}
