using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;


using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.stream_;
using System.Numerics;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num.real_
{
	[Obsolete()]
	public  class Quotient1
		
		:
		//Singleton
		//,
		RealI3
	{

		private Q1 _quotient;

		public Q1 quotient
		{
			get { return _quotient; }
			set { _quotient = value; }
		}

		public C choice => new nilnul.num._real.cauchy_.Quotient(-quotient);

		public Quotient1()
			:this(0)
		{

		}


		

		public Quotient1(Q1 val)
		{
			_quotient = val;
		}

		

		
		public Quotient1(int a,int b):this(new Q1(a,b))
		{

		}
		public Quotient1(long a,long b):this(new Q1(a,b))
		{

		}
		public Quotient1(ulong a,ulong b):this(new Q1(a,b))
		{

		}

		public Quotient1(int x):this((Q1) x)
		{
		}
		public Quotient1(long x):this( x,1)
		{
		}

		public Quotient1(ulong x):this((Q1) x)
		{
		}

		public Quotient1(BigInteger b):this( new Q1(b))
		{
		}
		public Quotient1(nilnul.Num b):this( new Q1(b))
		{
		}

		public override string ToString()
		{
			return _quotient.ToString();
		}


		static public Quotient1 NewZero() {
			return new Quotient1(0);
		}
		static public Quotient1 CreateZero() {
			return new Quotient1(0);
		}

		static public Quotient1 CreateOne() {
			return new Quotient1(1);
		}
		static public Quotient1 CreateUnitFrac(int x) {
			return new Quotient1(1,x);
		}
		static public Quotient1 CreatePercent(int x) {
			return new Quotient1(x,100);
		}



		static public Quotient1 Increment(Quotient1 x) {

			return new Quotient1(x.quotient+ new Q1( 1));
		}

		public static implicit operator Quotient1(nilnul.Num v)
		{
			return new Quotient1(v);
		}
		public static implicit operator Quotient1(BigInteger v)
		{
			return new Quotient1(v);
		}

		static public implicit operator Quotient1 (int x) {

			return new Quotient1(x);
		}

		static public bool operator ==(Quotient1 a, int x) {
			return a.quotient == x;
		}
		static public bool operator !=(Quotient1 a, int x) {
			return !(a == x);
		}

		static public Quotient1 operator *(int x, Quotient1 y) {
			return new Quotient1(new Q1( x) * y.quotient);
		}
		static public Quotient1 operator *(Q1 x, Quotient1 y) {
			return new Quotient1(x * y.quotient);
		}

		static public Quotient1 operator +(Quotient1 x, Quotient1 y) {
			return new Quotient1(x.quotient + y.quotient);
		}

		static public Quotient1 operator *( Quotient1 y, Q1 x) {
			return new Quotient1(x * y.quotient);
		}
		static public Quotient1 operator *( Quotient1 x, Quotient1 y) {
			return new Quotient1(x.quotient * y.quotient);
		}


		static public Quotient1 operator *( Quotient1 y, int x) {
			return new Quotient1(new Q1(x) * y.quotient);
		}
		static public Quotient1 operator -( Quotient1 y) {
			return new Quotient1(- y.quotient);
		}


		static public Quotient1 operator /( Quotient1 y, Quotient1 x) {
			return new Quotient1(y.quotient /x.quotient);
		}

		static public implicit operator Quotient1 ( Q1 x) {

			return new Quotient1(
				x
				
			);
		}

		static public implicit operator Q1 ( Quotient1 x) {

			return x.quotient;
		}


		

	}
}
