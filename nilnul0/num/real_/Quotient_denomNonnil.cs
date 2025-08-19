using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.quotient_.DenomNonnil;


using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.stream_;
using System.Numerics;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.obj.stream_._slider._skid_;

namespace nilnul.num.real_
{
	public  class Quotient_denomNonnil
		:
		nilnul.obj.Box_pub<

			Q1>
		,
		//Singleton
		//,
		RealI_onQuotient, IEquatable<Quotient_denomNonnil>
	{
		//public C choice => new nilnul.num._real.cauchy_.Quotient(-boxed);

		public (Q1 begin, Q1 end) current => (boxed,boxed); 
		public Quotient_denomNonnil()
			:this(
				 nilnul.num.quotient_.DenomNonnil.Nil
				)
		{
		}

		public Quotient_denomNonnil(Q1 val):base(val)
		{
		}

		public static Quotient_denomNonnil CreateHalf()
		{
			return new Quotient_denomNonnil(Q1.Secondth);
		}

		public Quotient_denomNonnil(nilnul.num.QuotientI val):this(new Q1(val))
		{
		}

		public Quotient_denomNonnil(int a,int b):this(new Q1(a,b))
		{

		}
		public Quotient_denomNonnil(long a,long b):this(new Q1(a,b))
		{
		}

		public Quotient_denomNonnil(ulong a,ulong b):this(new Q1(a,b))
		{
		}

		public Quotient_denomNonnil(int x):this((Q1) x)
		{
		}

		static public Quotient_denomNonnil Of(int x) {
			switch (x)
			{
				case 0:
					return Nil;
				case 1:
					return One;
				case -1:
					return NegOne;
				default:
					break;
			}
			return new Quotient_denomNonnil(x);
		}
		public Quotient_denomNonnil(long x):this( x,1)
		{
		}

		public Quotient_denomNonnil(ulong x):this((Q1) x)
		{
		}

		public Quotient_denomNonnil(BigInteger b):this( new Q1(b))
		{
		}

		public Quotient_denomNonnil(nilnul.Num b):this( new Q1(b))
		{
		}
		public Quotient_denomNonnil(nilnul.Num1 b):this( new Q1(b))
		{
		}


		public Quotient_denomNonnil(NumI1 b):this(
			new Q1(b.toBigint())
		)
		{
		}

		public Quotient_denomNonnil(QuotientI1 quotient):this(new Q1(quotient.numerator,quotient.denominator1))
		{
		}

		public Quotient_denomNonnil(DenomNonnilI quotient):this(quotient.ToImpl())
		{
		}

		public override string ToString()
		{
			return boxed.ToString();
		}

		static public Quotient_denomNonnil NewZero() {
			return new Quotient_denomNonnil(0);
		}

		static public readonly Quotient_denomNonnil Nil= new Quotient_denomNonnil();
		static public readonly Quotient_denomNonnil One= new Quotient_denomNonnil(1);

		static public readonly Quotient_denomNonnil NegOne= new Quotient_denomNonnil(-1);

		static public Quotient_denomNonnil CreateZero() {
			return new Quotient_denomNonnil(0);
		}

		static public Quotient_denomNonnil CreateOne() {
			return new Quotient_denomNonnil(1);
		}

		static public Quotient_denomNonnil CreateUnitFrac(int x) {
			return new Quotient_denomNonnil(1,x);
		}
		static public Quotient_denomNonnil CreateByDivide(BigInteger x, BigInteger y) {
			return new Quotient_denomNonnil(
				new Q1(x,y)
			);
		}


		static public Quotient_denomNonnil CreatePercent(int x) {
			return new Quotient_denomNonnil(x,100);
		}

		static public Quotient_denomNonnil Increment(Quotient_denomNonnil x) {
			return new Quotient_denomNonnil(x.boxed+ new Q1( 1));
		}

		//public void squeeze(num.quotient_.Positive1 diameter)
		//{
		//	return;
		//}

		public bool Equals(Quotient_denomNonnil other)
		{
			return !( other    is  null  )   &&
				   nilnul.num.quotient.Eq2.Singleton.Equals(boxed, other.boxed);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Quotient_denomNonnil);
		}

		public override int GetHashCode()
		{
			return 2029503587 + nilnul.num.quotient.Eq2.Singleton.GetHashCode(this.boxed);
		}

		

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			return;
		}

		public static implicit operator Quotient_denomNonnil(nilnul.Num1 v)
		{
			return new Quotient_denomNonnil(v);
		}

		public static implicit operator Quotient_denomNonnil(nilnul.Num v)
		{
			return new Quotient_denomNonnil(v);
		}

		public static implicit operator Quotient_denomNonnil(BigInteger v)
		{
			return new Quotient_denomNonnil(v);
		}

		static public implicit operator Quotient_denomNonnil(int x) {

			return new Quotient_denomNonnil(x);
		}
		static public bool operator <(Quotient_denomNonnil a, int x) {
			return a.boxed < x;
		}
		static public bool operator >(Quotient_denomNonnil a, int x) {
			return a.boxed > x;
		}

		static public bool operator <=(Quotient_denomNonnil a, int x) {
			return !(a>x);
		}
		static public bool operator >=(Quotient_denomNonnil a, int x) {
			return !(a<x);
		}

		static public bool operator ==(Quotient_denomNonnil a, int x) {
			return a.boxed == x;
		}
		static public bool operator !=(Quotient_denomNonnil a, int x) {
			return !(a == x);
		}

		static public Quotient_denomNonnil operator *(int x, Quotient_denomNonnil y) {
			return new Quotient_denomNonnil(new Q1( x) * y.boxed);
		}
		static public Quotient_denomNonnil operator *(Q1 x, Quotient_denomNonnil y) {
			return new Quotient_denomNonnil(x * y.boxed);
		}
		static public Real operator *(Real x, Quotient_denomNonnil y) {
			return x * y.boxed;
		}
		static public Real operator *(Quotient_denomNonnil y, Real x) {
			return x * y.boxed;
		}

		static public Real operator *(RealI x, Quotient_denomNonnil y) {
			return new Real(x)*y;
		}

		static public Real operator *(Quotient_denomNonnil y, RealI x) {
			return new Real(x)*y;
		}

		static public Quotient_denomNonnil operator +(Quotient_denomNonnil x, Quotient_denomNonnil y) {
			return new Quotient_denomNonnil(x.boxed + y.boxed);
		}

		static public Quotient_denomNonnil operator *(Quotient_denomNonnil y, Q1 x) {
			return new Quotient_denomNonnil(x * y.boxed);
		}
		static public Quotient_denomNonnil operator *(Quotient_denomNonnil x, Quotient_denomNonnil y) {
			return new Quotient_denomNonnil(x.boxed * y.boxed);
		}

		static public Quotient_denomNonnil operator *(Quotient_denomNonnil y, int x) {
			return new Quotient_denomNonnil(new Q1(x) * y.boxed);
		}
		static public Quotient_denomNonnil operator -(Quotient_denomNonnil y) {
			return new Quotient_denomNonnil(- y.boxed);
		}

		static public Quotient_denomNonnil operator /(Quotient_denomNonnil y, Quotient_denomNonnil x) {
			return new Quotient_denomNonnil(y.boxed /x.boxed);
		}

		static public implicit operator Quotient_denomNonnil( Q1 x) {
			return new Quotient_denomNonnil(
				x
			);
		}

		static public implicit operator Q1 (Quotient_denomNonnil x) {
			return x.boxed;
		}
	}
}