using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;


using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.stream_;
using System.Numerics;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num.real_
{
	public  class Quotient
		:
		nilnul.obj.Box_pub<

			Q1>
		,
		//Singleton
		//,
		RealI, IEquatable<Quotient>
	{
		//public C choice => new nilnul.num._real.cauchy_.Quotient(-boxed);

		public num.quotient.bound_.Closed current =>new  num.quotient.bound_.Closed(boxed);

		public Quotient()
			:this(
				 nilnul.num.Quotient1.CreateZero()
				)
		{
		}

		public Quotient(Q1 val):base(val)
		{
		}

		public static Quotient CreateHalf()
		{
			return new Quotient(Q1.CreateHalf());
		}

		public Quotient(nilnul.num.QuotientI val):this(new Q1(val))
		{
		}

		public Quotient(int a,int b):this(new Q1(a,b))
		{

		}
		public Quotient(long a,long b):this(new Q1(a,b))
		{
		}

		public Quotient(ulong a,ulong b):this(new Q1(a,b))
		{
		}

		public Quotient(int x):this((Q1) x)
		{
		}

		static public Quotient Of(int x) {
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
			return new Quotient(x);
		}
		public Quotient(long x):this( x,1)
		{
		}

		public Quotient(ulong x):this((Q1) x)
		{
		}

		public Quotient(BigInteger b):this( new Q1(b))
		{
		}

		public Quotient(nilnul.Num b):this( new Q1(b))
		{
		}
		public Quotient(nilnul.Num1 b):this( new Q1(b))
		{
		}


		public Quotient(NumI1 b):this(
			new Q1(b)
		)
		{
		}

		public Quotient(QuotientI1 quotient):this(new Q1(quotient.numerator,quotient.denominator1))
		{
		}

		public override string ToString()
		{
			return boxed.ToString();
		}

		static public Quotient NewZero() {
			return new Quotient(0);
		}

		static public readonly Quotient Nil= new Quotient();
		static public readonly Quotient One= new Quotient(1);

		static public readonly Quotient NegOne= new Quotient(-1);

		static public Quotient CreateZero() {
			return new Quotient(0);
		}

		static public Quotient CreateOne() {
			return new Quotient(1);
		}

		static public Quotient CreateUnitFrac(int x) {
			return new Quotient(1,x);
		}
		static public Quotient CreateByDivide(BigInteger x, BigInteger y) {
			return new Quotient(
				Q1.CreateByDivide(x,y)
			);
		}


		static public Quotient CreatePercent(int x) {
			return new Quotient(x,100);
		}

		static public Quotient Increment(Quotient x) {
			return new Quotient(x.boxed+ new Q1( 1));
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			return;
		}

		public bool Equals(Quotient other)
		{
			return !( other    is  null  )   &&
				   nilnul.num.quotient.Eq1.Singleton.Equals(boxed, other.boxed);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Quotient);
		}

		public override int GetHashCode()
		{
			return 2029503587 + nilnul.num.quotient.Eq1.Singleton.GetHashCode(this.boxed);
		}

		public static implicit operator Quotient(nilnul.Num1 v)
		{
			return new Quotient(v);
		}

		public static implicit operator Quotient(nilnul.Num v)
		{
			return new Quotient(v);
		}

		public static implicit operator Quotient(BigInteger v)
		{
			return new Quotient(v);
		}

		static public implicit operator Quotient(int x) {

			return new Quotient(x);
		}
		static public bool operator <(Quotient a, int x) {
			return a.boxed < x;
		}
		static public bool operator >(Quotient a, int x) {
			return a.boxed > x;
		}

		static public bool operator <=(Quotient a, int x) {
			return !(a>x);
		}
		static public bool operator >=(Quotient a, int x) {
			return !(a<x);
		}

		static public bool operator ==(Quotient a, int x) {
			return a.boxed == x;
		}
		static public bool operator !=(Quotient a, int x) {
			return !(a == x);
		}

		static public Quotient operator *(int x, Quotient y) {
			return new Quotient(new Q1( x) * y.boxed);
		}
		static public Quotient operator *(Q1 x, Quotient y) {
			return new Quotient(x * y.boxed);
		}
		static public Real operator *(Real x, Quotient y) {
			return x * y.boxed;
		}
		static public Real operator *(Quotient y, Real x) {
			return x * y.boxed;
		}

		static public Real operator *(RealI x, Quotient y) {
			return new Real(x)*y;
		}

		static public Real operator *(Quotient y, RealI x) {
			return new Real(x)*y;
		}

		static public Quotient operator +(Quotient x, Quotient y) {
			return new Quotient(x.boxed + y.boxed);
		}

		static public Quotient operator *(Quotient y, Q1 x) {
			return new Quotient(x * y.boxed);
		}
		static public Quotient operator *(Quotient x, Quotient y) {
			return new Quotient(x.boxed * y.boxed);
		}

		static public Quotient operator *(Quotient y, int x) {
			return new Quotient(new Q1(x) * y.boxed);
		}
		static public Quotient operator -(Quotient y) {
			return new Quotient(- y.boxed);
		}

		static public Quotient operator /(Quotient y, Quotient x) {
			return new Quotient(y.boxed /x.boxed);
		}

		static public implicit operator Quotient( Q1 x) {
			return new Quotient(
				x
			);
		}

		static public implicit operator Q1 (Quotient x) {
			return x.boxed;
		}
	}
}