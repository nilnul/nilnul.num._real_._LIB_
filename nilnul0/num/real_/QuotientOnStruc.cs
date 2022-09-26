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
	public  class QuotientOnStruc
		:
		nilnul.obj.Box_pub<
			num.Quotient_structUnsimplified
		>
		,
		//Singleton
		//,
		RealI, IEquatable<QuotientOnStruc>
	{
		//public C choice => new nilnul.num._real.cauchy_.Quotient(-boxed);

		public num.quotient.bound_.Closed current =>new  num.quotient.bound_.Closed(boxed);

		public QuotientOnStruc()
			:this(0)
		{
		}

		public QuotientOnStruc(Q1 val):base(val)
		{
		}

		public static QuotientOnStruc CreateHalf()
		{
			return new QuotientOnStruc(Q1.CreateHalf());
		}

		public QuotientOnStruc(nilnul.num.QuotientI val):this(new Q1(val))
		{
		}

		public QuotientOnStruc(int a,int b):this(new Q1(a,b))
		{

		}
		public QuotientOnStruc(long a,long b):this(new Q1(a,b))
		{
		}

		public QuotientOnStruc(ulong a,ulong b):this(new Q1(a,b))
		{
		}

		public QuotientOnStruc(int x):this((Q1) x)
		{
		}
		public QuotientOnStruc(long x):this( x,1)
		{
		}

		public QuotientOnStruc(ulong x):this((Q1) x)
		{
		}

		public QuotientOnStruc(BigInteger b):this( new Q1(b))
		{
		}

		public QuotientOnStruc(nilnul.Num b):this( new Q1(b))
		{
		}
		public QuotientOnStruc(nilnul.Num1 b):this( new Q1(b))
		{
		}


		public QuotientOnStruc(NumI1 b):this(
			new Q1(b)
		)
		{
		}

		public QuotientOnStruc(QuotientI1 quotient):this(new Q1(quotient.numerator,quotient.denominator1))
		{
		}

		public override string ToString()
		{
			return boxed.ToString();
		}

		static public QuotientOnStruc NewZero() {
			return new QuotientOnStruc(0);
		}

		static public readonly QuotientOnStruc Nil= new QuotientOnStruc();

		static public QuotientOnStruc CreateZero() {
			return new QuotientOnStruc(0);
		}

		static public QuotientOnStruc CreateOne() {
			return new QuotientOnStruc(1);
		}

		static public QuotientOnStruc CreateUnitFrac(int x) {
			return new QuotientOnStruc(1,x);
		}
		static public QuotientOnStruc CreateByDivide(BigInteger x, BigInteger y) {
			return new QuotientOnStruc(
				Q1.CreateByDivide(x,y)
			);
		}


		static public QuotientOnStruc CreatePercent(int x) {
			return new QuotientOnStruc(x,100);
		}

		static public QuotientOnStruc Increment(QuotientOnStruc x) {
			return new QuotientOnStruc(x.boxed+ new Q1( 1));
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			return;
		}

		public bool Equals(QuotientOnStruc other)
		{
			return !( other    is  null  )   &&
				   nilnul.num.quotient.Eq1.Singleton.Equals(boxed, other.boxed);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as QuotientOnStruc);
		}

		public override int GetHashCode()
		{
			return 2029503587 + nilnul.num.quotient.Eq1.Singleton.GetHashCode(this.boxed);
		}

		public static implicit operator QuotientOnStruc(nilnul.Num1 v)
		{
			return new QuotientOnStruc(v);
		}

		public static implicit operator QuotientOnStruc(nilnul.Num v)
		{
			return new QuotientOnStruc(v);
		}

		public static implicit operator QuotientOnStruc(BigInteger v)
		{
			return new QuotientOnStruc(v);
		}

		static public implicit operator QuotientOnStruc(int x) {

			return new QuotientOnStruc(x);
		}
		static public bool operator <(QuotientOnStruc a, int x) {
			return a.boxed < x;
		}
		static public bool operator >(QuotientOnStruc a, int x) {
			return a.boxed > x;
		}

		static public bool operator <=(QuotientOnStruc a, int x) {
			return !(a>x);
		}
		static public bool operator >=(QuotientOnStruc a, int x) {
			return !(a<x);
		}

		static public bool operator ==(QuotientOnStruc a, int x) {
			return a.boxed == x;
		}
		static public bool operator !=(QuotientOnStruc a, int x) {
			return !(a == x);
		}

		static public QuotientOnStruc operator *(int x, QuotientOnStruc y) {
			return new QuotientOnStruc(new Q1( x) * y.boxed);
		}
		static public QuotientOnStruc operator *(Q1 x, QuotientOnStruc y) {
			return new QuotientOnStruc(x * y.boxed);
		}
		static public Real operator *(Real x, QuotientOnStruc y) {
			return x * y.boxed;
		}
		static public Real operator *(QuotientOnStruc y, Real x) {
			return x * y.boxed;
		}

		static public Real operator *(RealI x, QuotientOnStruc y) {
			return new Real(x)*y;
		}

		static public Real operator *(QuotientOnStruc y, RealI x) {
			return new Real(x)*y;
		}

		static public QuotientOnStruc operator +(QuotientOnStruc x, QuotientOnStruc y) {
			return new QuotientOnStruc(x.boxed + y.boxed);
		}

		static public QuotientOnStruc operator *(QuotientOnStruc y, Q1 x) {
			return new QuotientOnStruc(x * y.boxed);
		}
		static public QuotientOnStruc operator *(QuotientOnStruc x, QuotientOnStruc y) {
			return new QuotientOnStruc(x.boxed * y.boxed);
		}

		static public QuotientOnStruc operator *(QuotientOnStruc y, int x) {
			return new QuotientOnStruc(new Q1(x) * y.boxed);
		}
		static public QuotientOnStruc operator -(QuotientOnStruc y) {
			return new QuotientOnStruc(- y.boxed);
		}

		static public QuotientOnStruc operator /(QuotientOnStruc y, QuotientOnStruc x) {
			return new QuotientOnStruc(y.boxed /x.boxed);
		}

		static public implicit operator QuotientOnStruc( Q1 x) {
			return new QuotientOnStruc(
				x
			);
		}

		static public implicit operator Q1 (QuotientOnStruc x) {
			return x.boxed;
		}
	}
}