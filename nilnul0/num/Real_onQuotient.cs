using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_onQuotient;
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
	public class Real_onQuotient
		: nilnul.obj.Box_pub<R>
		,
		R
	{

		[Obsolete("use " + nameof(Ov) + " to avoid too much boxes; this shall be used private by " + nameof(Of) + " where some recursive unwrapping happens."
			//,true
			)]



		private Real_onQuotient(R v) : base(
			//v is Real_onQuotient x ? x.boxed :
			v

		)
		{

		}
		static public Real_onQuotient Of(R x)
		{
			if (x is Real_onQuotient r)
			{
				return r;
			}
			return new Real_onQuotient(x);
		}
		static public Real_onQuotient Ov(Real_onQuotient x)
		{

			return x;
		}

		public Real_onQuotient(nilnul.num.real_.Quotient_denomNonnil n) : this((R)(n))
		{
		}
		//public Real_onQuotient(nilnul.num.quotient_.DenomNonnil n) : this(new nilnul.num.real_.Quotient_denomNonnil(n))
		//{
		//}

		public Real_onQuotient(BigInteger n) : this(new nilnul.num.real_.Quotient_denomNonnil(n))
		{
		}
		public Real_onQuotient(quotient_.DenomNonnil q) : this(new nilnul.num.real_.Quotient_denomNonnil(q))
		{
		}


		public Real_onQuotient() : this(0)
		{
		}

		public (Q1 begin, Q1 end) current
		{
			get
			{
				return boxed.current;
			}
		}

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
		static public implicit operator Real_onQuotient(nilnul.Num1 q)
		{
			return new Real_onQuotient(q);
		}



		static public implicit operator Real_onQuotient(real_.Quotient_denomNonnil q)
		{
			return new Real_onQuotient(q);
		}



		static public implicit operator Real_onQuotient(Q1 q)
		{
			return new nilnul.num.real_.Quotient_denomNonnil(q);
		}


		static public implicit operator Real_onQuotient(BigInteger q)
		{
			return new Real_onQuotient((real_.Quotient_denomNonnil)q);
		}

		static public implicit operator Real_onQuotient(int q)
		{
			return new Real_onQuotient((real_.Quotient_denomNonnil)q);
		}



		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public RealI_onQuotient operator +(Real_onQuotient a, Real_onQuotient b)
		{
			return (nilnul.num.real.op_.binary_.Add.Singleton.op(a, b));
		}

		static public RealI_onQuotient operator +(Real_onQuotient a, R b)
		{
			return  nilnul.num.real.op_.binary_.Add.Singleton.op(a, b);
		}

		static public Real_onQuotient operator +(RealI_onQuotient a, Real_onQuotient b)
		{
			return Of(nilnul.num.real.of_.binary_.Add.Singleton.op(a, b));
		}

		static public RealI_onQuotient operator -(Real_onQuotient a, Real_onQuotient b)
		{
			return (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}

		static public RealI_onQuotient operator -(Real_onQuotient a, nilnul.num.quotient_.DenomNonnil b)
		{
			return  (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}
		static public RealI_onQuotient operator -(Real_onQuotient a, nilnul.num.quotient_.DenomNonnilI b)
		{
			return (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}

		static public RealI_onQuotient operator -( nilnul.num.quotient_.DenomNonnilI b,Real_onQuotient a)
		{
			return (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}


		static public RealI_onQuotient operator ^(Real_onQuotient a, int b)
		{
			return nilnul.num.real.op_._IndicandX.RealI(a, b);
		}

		static public RealI_onQuotient operator -(R a, Real_onQuotient b)
		{
			return (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}
		static public RealI_onQuotient operator -(Real_onQuotient a, R b)
		{
			return (nilnul.num.real.of_.binary_.Minus.Singleton.op(a, b));
		}
		static public RealI_onQuotient operator -(Real_onQuotient a)
		{
			return (nilnul.num.real.op_.Neg.Singleton.op(a));
		}

		static public bool operator <=(Real_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator <=(Real_onQuotient a, RealI_onQuotient b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator <=(RealI_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}

		static public bool operator >=(RealI_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, b);
		}

		static public bool operator >=(Real_onQuotient a, RealI_onQuotient b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, b);
		}

		static public bool operator <(Real_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}
		static public bool operator <(R a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}

		static public bool operator <(Real_onQuotient a, nilnul.num.quotient_.denomNonnil_.Positive b)
		{
			return nilnul.num.real.re_.Lt.Singleton.re(a, b);
		}

		static public bool operator >(Real_onQuotient a, nilnul.num.quotient_.denomNonnil_.Positive b)
		{
			return nilnul.num.real.re_.Gt.Singleton.re(a, b);
		}


		static public bool operator <(Real_onQuotient a, R b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, b);
		}



		static public bool operator >(Real_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, b);
		}

		static public bool operator >(Real_onQuotient a, int b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator <(Real_onQuotient a, int b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >=(Real_onQuotient a, int b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}
		static public bool operator <=(Real_onQuotient a, int b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator ==(Real_onQuotient a, int b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator !=(Real_onQuotient a, int b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}



		static public bool operator >(Real_onQuotient a, long b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, (b));
		}

		static public bool operator <(Real_onQuotient a, long b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >=(Real_onQuotient a, long b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}
		static public bool operator <=(Real_onQuotient a, long b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator ==(Real_onQuotient a, long b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator !=(Real_onQuotient a, long b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >(Real_onQuotient a, ulong b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator <(Real_onQuotient a, ulong b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >=(Real_onQuotient a, ulong b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}
		static public bool operator <=(Real_onQuotient a, ulong b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator ==(Real_onQuotient a, ulong b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator !=(Real_onQuotient a, ulong b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}


		static public bool operator >(Real_onQuotient a, BigInteger b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator <(Real_onQuotient a, BigInteger b)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator <=(Real_onQuotient a, nilnul.num.quotient_.DenomNonnil b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}

		static public bool operator <=(Real_onQuotient a, nilnul.num.quotient_.DenomNonnilI b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, b);
		}
		static public bool operator <=( nilnul.num.quotient_.DenomNonnilI a0,Real_onQuotient b)
		{
			return nilnul.num.real.re_.Le.Lazy.re( a0,b);
		}

		static public bool operator >=( nilnul.num.quotient_.DenomNonnilI a,Real_onQuotient b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re( a,b);
		}

		static public bool operator >=(Real_onQuotient a, BigInteger b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >=(Real_onQuotient a, nilnul.num.quotient_.DenomNonnilI b)
		{
			return (b<=a);
		}

		static public bool operator >=(Real_onQuotient a, nilnul.num.quotient_.DenomNonnil b)
		{
			return !(a < b);
		}

		static public bool operator <=(Real_onQuotient a, BigInteger b)
		{
			return nilnul.num.real.re_.Le.Lazy.re(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator ==(Real_onQuotient a, RealI_onQuotient b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real_onQuotient a, RealI_onQuotient b)
		{
			return !(a == (b));
		}

		static public bool operator ==(RealI_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(RealI_onQuotient a, Real_onQuotient b)
		{
			return !(a == (b));
		}


		static public bool operator ==(Real_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, (b));
		}

		static public bool operator !=(Real_onQuotient a, Real_onQuotient b)
		{
			return !(a == (b));
		}

		static public bool operator ==(Real_onQuotient a, BigInteger b)
		{
			return nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator !=(Real_onQuotient a, BigInteger b)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(a, new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		static public bool operator >(int b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator <(int b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator >=(int b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}
		static public bool operator <=(int b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Le.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator ==(int b, Real_onQuotient c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator !=(int b, Real_onQuotient c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}


		static public bool operator >(long b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator <(long b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator >=(long b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}
		static public bool operator <=(long b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Le.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator ==(long b, Real_onQuotient c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator !=(long b, Real_onQuotient c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}


		static public bool operator >(ulong b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator <(ulong b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator >=(ulong b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}
		static public bool operator <=(ulong b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Le.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator ==(ulong b, Real_onQuotient c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator !=(ulong b, Real_onQuotient c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator >(BigInteger b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator <(BigInteger b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Lt.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator >=(BigInteger b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}
		static public bool operator <=(BigInteger b, Real_onQuotient c)
		{
			return nilnul.num.real.re_.Le.Lazy.re(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator ==(BigInteger b, Real_onQuotient c)
		{
			return nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}

		static public bool operator !=(BigInteger b, Real_onQuotient c)
		{
			return !nilnul.num.real.Eq.Singleton.Equals(new nilnul.num.real_.Quotient_denomNonnil(b), c);
		}



		static public bool operator >(R a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a, b);
		}
		static public bool operator >(Real_onQuotient a, R b)
		{
			return nilnul.num.real.re_.Gt.Lazy.re(a.boxed, b);
		}

		static public bool operator >=(Real_onQuotient a, Real_onQuotient b)
		{
			return nilnul.num.real.re_.Ge.Lazy.re(a, b);
		}

		static public RealI_onQuotient operator *(int b, Real_onQuotient a)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}

		static public RealI_onQuotient operator *(BigInteger b, Real_onQuotient a)
		{
			return  (nilnul.num.real.op_._ScaleX.Op(b, a));
		}
		static public RealI_onQuotient operator *(nilnul.Num1 b, Real_onQuotient a)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}

		static public RealI_onQuotient operator *(nilnul.num.quotient_.DenomNonnilI b, Real_onQuotient a)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}

		//static public Real_onQuotient operator *( nilnul.num.quotient_.DenomNonnil b, Real_onQuotient a)
		//{
		//	return new Real_onQuotient(nilnul.num.real.op_._ScaleX.Op(b,a));
		//}
		static public RealI_onQuotient operator *(nilnul.num.quotient_.DenomNonnil b, Real_onQuotient a)
		{
			return nilnul.num.real.op_._ScaleX.Op(b, a);
		}

		static public RealI_onQuotient operator *(R a, Real_onQuotient b)
		{
			return (nilnul.num.real.of_.binary_.Multi.Singleton.op(a, b));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, int b)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, BigInteger b)
		{
			return  (nilnul.num.real.op_._ScaleX.Op(b, a));
		}

		static public RealI_onQuotient operator *(Real_onQuotient a, nilnul.NumI1 b)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, nilnul.Num1 b)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, nilnul.num.quotient_.DenomNonnilI b)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, nilnul.num.quotient_.DenomNonnil b)
		{
			return (nilnul.num.real.op_._ScaleX.Op(b, a));
		}

		static public RealI_onQuotient operator *(Real_onQuotient a, R b)
		{
			return  (nilnul.num.real.of_.binary_.Multi.Singleton.op(a, b));
		}
		static public RealI_onQuotient operator *(Real_onQuotient a, Real_onQuotient b)
		{
			return  (nilnul.num.real.of_.binary_.Multi.Singleton.op(a, b));
		}



		//static public Real operator *(Real a, nilnul.NumI1 b)
		//{
		//	return new Real(nilnul.num.real.op_.unary_._ScaleX.Op(b,a));
		//}

		#region / the division


		static public RealI_onQuotient operator /(Q1 a, Real_onQuotient b)
		{
			return (
				nilnul.num.real.co_.divisible._DivX.Bind(
					a
					,

					b
				)
			);
		}
		static public RealI_onQuotient operator /(Real_onQuotient a, N b)
		{
			return (nilnul.num.real.co_.divisible._DivX.Divide(a, b));
		}

		static public RealI_onQuotient operator /(Real_onQuotient a, Real_onQuotient b)
		{
			return (nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}


		static public RealI_onQuotient operator /(R a, Real_onQuotient b)
		{
			return (nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}
		static public RealI_onQuotient operator /(Real_onQuotient a, R b)
		{
			return (nilnul.num.real.co_.divisible._DivX.Bind(a, b));
		}

		#endregion


		static public Real_onQuotient CreateOne()
		{
			return 1;
		}

		static public Real_onQuotient CreateZero() { return 0; }

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			this.boxed.cinch(diameter);
		}
		public RealI_onQuotient sqrt()
		{
			return (nilnul.num.real_.nonneg.op_.Sqrt.Singleton.op(this));
		}

	}
}
