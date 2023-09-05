using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
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
	public class Real
		: nilnul.obj.Box_pub<R>
		,
		R
	{
		//public R boxed { get { return base.boxed; } }

		[Obsolete("use "+ nameof(Ov) + " to avoid too much boxes; this shall be used private by "+nameof(Ov) + " where some recursive unwrapping happens.")]
		public Real(R v) : base(
			v is Real x?x.boxed:v

		)
		{

		}
		static public Real Ov(RealI x)
		{
			if (x is Real r)
			{
				return r;
			}
			return new Real(x);
		}
		static public Real Ov(Real x)
		{

			return x;
		}

		public Real(nilnul.num.real_.Quotient n) : this((R)(n))
		{
		}
		public Real(nilnul.num.Quotient1 n) : this(new nilnul.num.real_.Quotient(n))
		{
		}

		public Real(BigInteger n) : this(new nilnul.num.real_.Quotient(n))
		{
		}
		public Real(QuotientI1 q):this(new nilnul.num.real_.Quotient(q) )
		{
		}


		public Real():this(0)
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
		static public implicit operator Real(nilnul.Num1 q)
		{
			return new Real(q);
		}



		static public implicit operator Real(real_.Quotient q)
		{
			return new Real(q);
		}



		static public implicit operator Real(Q1 q)
		{
			return new nilnul.num.real_.Quotient(q);
		}


		static public implicit operator Real(BigInteger q)
		{
			return new Real((real_.Quotient)q);
		}

		static public implicit operator Real(int q)
		{
			return new Real((real_.Quotient)q);
		}



		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public Real operator +(Real a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real operator +(Real a, R b)
		{
			return new Real(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real operator +(RealI a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public Real operator -(Real a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}

		static public Real operator -(Real a, nilnul.num.Quotient1 b)
		{
			return new Real(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}

		static public Real operator ^(Real a, int b)
		{
			return nilnul.num.real.op_.unary_._IndexX.RetReal(a,b);
		}

		static public Real operator -(R a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real operator -(Real a, R b)
		{
			return new Real(nilnul.num.real.op_.binary_.Minus.Singleton.op(a, b));
		}
		static public Real operator -(Real a)
		{
			return new Real(nilnul.num.real.op_.unary_.Neg.Singleton.op(a));
		}

		static public bool operator <=(Real a, Real b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator <=(Real a, RealI b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator >=(Real a, RealI b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, b);
		}

		static public bool operator <(Real a, Real b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}
		static public bool operator <(R a, Real b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}

		static public bool operator <(Real a, nilnul.num.quotient_.PositiveI b)
		{
			return nilnul.num.real.re_.Lt.Singleton.re(a, b);
		}

		static public bool operator >(Real a, nilnul.num.quotient_.PositiveI b)
		{
			return nilnul.num.real.re_.Gt.Singleton.re(a, b);
		}


		static public bool operator <(Real a, R b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a.boxed, b);
		}



		static public bool operator >(Real a, Real b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, b);
		}

		static public bool operator >(Real a, int b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real a, int b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real a, int b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real a, int b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real a, int b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real a, int b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}



		static public bool operator >(Real a, long b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real a, long b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real a, long b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real a, long b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real a, long b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real a, long b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >(Real a, ulong b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real a, ulong b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real a, ulong b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real a, ulong b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real a, ulong b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real a, ulong b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}


		static public bool operator >(Real a, BigInteger b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator <(Real a, BigInteger b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >=(Real a, BigInteger b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}
		static public bool operator <=(Real a, nilnul.num.Quotient1 b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}

		static public bool operator >=(Real a, nilnul.num.Quotient1 b)
		{
			return !(a<=b);
		}

		static public bool operator <=(Real a, BigInteger b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator ==(Real a, RealI b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real a, RealI b)
		{
			return !(a == (b));
		}

		static public bool operator ==(RealI a, Real b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(RealI a, Real b)
		{
			return !(a == (b));
		}


		static public bool operator ==(Real a, Real b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real a, Real b)
		{
			return !(a == (b));
		}

		static public bool operator ==(Real a, BigInteger b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator !=(Real a, BigInteger b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient(b));
		}

		static public bool operator >(int b, Real c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(int b, Real c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(int b, Real c)
		{
			return nilnul.num.real.re_.Ge  .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(int b, Real c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(int b, Real c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(int b, Real c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}


		static public bool operator >(long b, Real c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(long b, Real c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(long b, Real c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(long b, Real c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(long b, Real c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(long b, Real c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}


		static public bool operator >(ulong b, Real c)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(ulong b, Real c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(ulong b, Real c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(ulong b, Real c)
		{
			return nilnul.num.real.re_.Le  .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(ulong b, Real c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(ulong b, Real c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >(BigInteger b, Real c)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator <(BigInteger b, Real c)
		{
			return nilnul.num.real.re_. Lt .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator >=(BigInteger b, Real c)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}
		static public bool operator <=(BigInteger b, Real c)
		{
			return nilnul.num.real.re_. Le .Lazy.re(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator ==(BigInteger b, Real c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}

		static public bool operator !=(BigInteger b, Real c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient(b), c);
		}



		static public bool operator >(R a, Real b)
		{
			return nilnul.num.real.re_. Gt .Lazy.re(a, b);
		}
		static public bool operator >(Real a, R b)
		{
			return nilnul.num.real.re_.Gt  .Lazy.re(a.boxed, b);
		}

		static public bool operator >=(Real a, Real b)
		{
			return nilnul.num.real.re_. Ge .Lazy.re(a, b);
		}

		static public Real operator *(Real a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}


		static public Real operator *(R a, Real b)
		{
			return new Real(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}
		static public Real operator *(Real a, R b)
		{
			return new Real(nilnul.num.real.op_.binary_.Multi.Singleton.op(a, b));
		}

		static public Real operator *(Real a, nilnul.num.QuotientI1 b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}
		static public Real operator *(Real a, nilnul.NumI1 b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *(Real a, BigInteger b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}
		static public Real operator *(BigInteger b,Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}



		//static public Real operator *(Real a, nilnul.NumI1 b)
		//{
		//	return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		//}
		static public Real operator *(Real a, nilnul.Num1 b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *( nilnul.Num1 b, Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *( nilnul.num.QuotientI1 b, Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *( nilnul.num.quotient_.DenomNonnil b, Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *(Real a, nilnul.num.Quotient1 b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}


		static public Real operator *(Real a, nilnul.num.quotient_.DenomNonnil b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *( nilnul.num.Quotient1 b, Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *( int b, Real a)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}

		static public Real operator *(  Real a,int b)
		{
			return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		}


		static public Real operator /(Real a, Real b)
		{
			return new Real(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real operator /(Real a, N b)
		{
			return new Real(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real operator /(R a, Real b)
		{
			return new Real(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}
		static public Real operator /(Real a, R b)
		{
			return new Real(nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		static public Real operator /(Q1 a, Real b)
		{
			return new Real(
				nilnul.num.real.co_.divisible._DivX.Bind(
					a
					,

					b
				)
			);
		}


		static public Real CreateOne()
		{
			return 1;
		}

		static public Real CreateZero() { return 0; }

		public void squeeze(Positive1 diameter)
		{
			this.boxed.squeeze(diameter);
		}
		public Real sqrt()
		{
			return new Real(nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(this));
		}

	}
}
