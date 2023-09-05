using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI1;
using Q1 = nilnul.num.quotient_.DenomNonnil;
using N = nilnul.NumI;
using System.Numerics;
using nilnul.num.quotient.stream_.cauchy.sed.be_.cofinal.vow;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num
{


	/// <summary>
	/// Wrap a real with operators
	/// </summary>
	public class Real1
		: nilnul.obj.Box_pub<R>
		,
		R
	{
		
		static public Real1 Of(RealI1 x)
		{
			if (x is Real1 r)
			{
				return r;
			}
			return new Real1(x);
		}
		static public Real1 Ov(Real1 x)
		{

			return x;
		}

		public Real1(nilnul.num.real_.Quotient n) : this((R)(n))
		{
		}
		public Real1(nilnul.num.Quotient1 n) : this(new nilnul.num.real_.Quotient(n))
		{
		}

		public Real1(BigInteger n) : this(new nilnul.num.real_.Quotient(n))
		{
		}
		public Real1(QuotientI1 q):this(new nilnul.num.real_.Quotient(q) )
		{
		}


		public Real1():this(0)
		{
		}

		public quotient.bound_.Closed current => boxed.current;

		//public En cofinal => boxed.cofinal;

		//public  Real1 poly( N n) {
		//	return nilnul.num.real.op_.Poly.Singleton.eval(this, n).ToReal();
		//}

		//public static Real1 Div(int v, R diameter)
		//{
		//	return  nilnul.num.real.co_.divisible.op_.Div.Singleton.eval(v, diameter).ToReal();

		//	throw new NotImplementedException();
		//}



		//public Real1 sqrt() {
		//	return nilnul.num.real_.nonNeg.op_.Sqrt.Singleton.eval( this.boxed).ToReal();
		//}
		static public implicit operator Real1(nilnul.Num1 q)
		{
			return new Real1(q);
		}



		static public implicit operator Real1(real_.Quotient q)
		{
			return new Real(q);
		}



		static public implicit operator Real1(Q1 q)
		{
			return new nilnul.num.real_.Quotient(q);
		}


		static public implicit operator Real1(BigInteger q)
		{
			return new Real((real_.Quotient)q);
		}

		static public implicit operator Real1(int q)
		{
			return new Real((real_.Quotient)q);
		}



		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public Real1 operator +(Real1 a, Real1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real1 operator +(Real1 a, R b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real1 operator +(RealI a, Real1 b)
		{
			return new Real(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real1 operator -(Real1 a, Real1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}

		static public Real1 operator -(Real1 a, nilnul.num.Quotient1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}

		static public Real1 operator ^(Real1 a, int b)
		{
			return nilnul.num.real.op_.unary_._IndexX.RetReal(a,b);
		}

		static public Real1 operator -(R a, Real1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real1 operator -(Real1 a, R b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real1 operator -(Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_.Neg.Singleton.op(a));
		}

		static public bool operator <=(Real1 a, Real1 b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator <(Real1 a, Real1 b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}
		static public bool operator <(R a, Real1 b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}

		static public bool operator <(Real1 a, nilnul.num.quotient_.PositiveI b)
		{
			return nilnul.num.real.re_.Lt.Singleton.re(a, b);
		}

		static public bool operator >(Real1 a, nilnul.num.quotient_.PositiveI b)
		{
			return nilnul.num.real.re_.Gt.Singleton.re(a, b);
		}


		static public bool operator <(Real1 a, R b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a.boxed, b);
		}



		static public bool operator >(Real1 a, Real1 b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, b);
		}

		static public bool operator >(Real1 a, int b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real1 a, int b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real1 a, int b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real1 a, int b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real1 a, int b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real1 a, int b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}



		static public bool operator >(Real1 a, long b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real1 a, long b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real1 a, long b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real1 a, long b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real1 a, long b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real1 a, long b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >(Real1 a, ulong b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real1 a, ulong b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real1 a, ulong b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real1 a, ulong b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real1 a, ulong b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real1 a, ulong b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}


		static public bool operator >(Real1 a, BigInteger b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real1 a, BigInteger b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real1 a, BigInteger b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real1 a, nilnul.num.Quotient1 b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}

		static public bool operator >=(Real1 a, nilnul.num.Quotient1 b)
		{
			return !(a<=b);
		}

		static public bool operator <=(Real1 a, BigInteger b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real1 a, RealI b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real1 a, RealI b)
		{
			return !(a == (b));
		}

		static public bool operator ==(RealI a, Real1 b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(RealI a, Real1 b)
		{
			return !(a == (b));
		}


		static public bool operator ==(Real1 a, Real1 b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real1 a, Real1 b)
		{
			return !(a == (b));
		}

		static public bool operator ==(Real1 a, BigInteger b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real1 a, BigInteger b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >(int b, Real1 c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(int b, Real1 c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(int b, Real1 c)
		{
			return nilnul.num.real.re_.Ge  .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(int b, Real1 c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(int b, Real1 c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(int b, Real1 c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}


		static public bool operator >(long b, Real1 c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(long b, Real1 c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(long b, Real1 c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(long b, Real1 c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(long b, Real1 c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(long b, Real1 c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}


		static public bool operator >(ulong b, Real1 c)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(ulong b, Real1 c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(ulong b, Real1 c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(ulong b, Real1 c)
		{
			return nilnul.num.real.re_.Le  .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(ulong b, Real1 c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(ulong b, Real1 c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >(BigInteger b, Real1 c)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(BigInteger b, Real1 c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(BigInteger b, Real1 c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(BigInteger b, Real1 c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(BigInteger b, Real1 c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(BigInteger b, Real1 c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}



		static public bool operator >(R a, Real1 b)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(a, b);
		}
		static public bool operator >(Real1 a, R b)
		{
			return nilnul.num.real.re_.Gt  .Lazy.re(a.boxed, b);
		}

		static public bool operator >=(Real1 a, Real1 b)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(a, b);
		}

		static public Real1 operator *(Real1 a, Real1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}


		static public Real1 operator *(R a, Real1 b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}
		static public Real1 operator *(Real1 a, R b)
		{
			return new Real1(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}

		static public Real1 operator *(Real1 a, nilnul.num.QuotientI1 b)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}
		static public Real1 operator *(Real1 a, nilnul.NumI1 b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *(Real1 a, BigInteger b)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}
		static public Real1 operator *(BigInteger b,Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}



		//static public Real operator *(Real a, nilnul.NumI1 b)
		//{
		//	return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		//}
		static public Real1 operator *(Real1 a, nilnul.Num1 b)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *( nilnul.Num1 b, Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *( nilnul.num.QuotientI1 b, Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *( nilnul.num.quotient_.DenomNonnil b, Real1 a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *(Real1 a, nilnul.num.Quotient1 b)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}


		static public Real1 operator *(Real1 a, nilnul.num.quotient_.DenomNonnil b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *( nilnul.num.Quotient1 b, Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *( int b, Real1 a)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real1 operator *(  Real1 a,int b)
		{
			return new Real1(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}


		static public Real1 operator /(Real1 a, Real1 b)
		{
			return new Real1(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real1 operator /(Real1 a, N b)
		{
			return new Real1(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real1 operator /(R a, Real1 b)
		{
			return new Real1(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}
		static public Real1 operator /(Real1 a, R b)
		{
			return new Real1(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real1 operator /(Q1 a, Real1 b)
		{
			return new Real1(
				nilnul.num.real.co_.divisible._DivX.Bind(
					a
					,

					b
				)
			);
		}


		static public Real1 CreateOne()
		{
			return 1;
		}

		static public Real1 CreateZero() { return 0; }

		public void squeeze(Positive1 diameter)
		{
			this.boxed.squeeze(diameter);
		}
		public Real1 sqrt()
		{
			return new Real1(nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(this));
		}

	}
}
