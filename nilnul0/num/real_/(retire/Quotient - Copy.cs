using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul._num.bigint.be;

namespace nilnul.num.real_
{
	[Obsolete(nameof(Quotient1))]
	public partial class Quotient
		
		:
		Singleton
		,RealI2
	{

		private Q _q;

		public Q q
		{
			get { return _q; }
			set { _q = value; }
		}

		public Quotient()
			:this(0)
		{

		}


		

		public Quotient(Q val)
			:base(new num._real.approach.generator_.Quotient(val))
		{
			_q = val;
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

		public Quotient(int x):this((Q) x)
		{
		}
		public Quotient(long x):this( x,1)
		{
		}

		public Quotient(ulong x):this((Q) x)
		{
		}


		public override string ToString()
		{
			return _q.ToString();
		}


		static public Quotient NewZero() {
			return new Quotient(0);
		}
		static public Quotient CreateZero() {
			return new Quotient(0);
		}

		static public Quotient CreateOne() {
			return new Quotient(1);
		}
		static public Quotient CreateUnitFrac(int x) {
			return new Quotient(1,x);
		}
		static public Quotient CreatePercent(int x) {
			return new Quotient(x,100);
		}



		static public Quotient Increment(Quotient x) {

			return new Quotient(x.q+ 1);
		}

		public static implicit operator Quotient(Natural.Asserted v)
		{
			return new Quotient(v);
		}

		static public implicit operator Quotient (int x) {

			return new Quotient(x);
		}

		static public bool operator ==(Quotient a, int x) {
			return a.q == x;
		}
		static public bool operator !=(Quotient a, int x) {
			return !(a == x);
		}

		static public Quotient operator *(int x, Quotient y) {
			return new Quotient(x * y.q);
		}
		static public Quotient operator *(Q1 x, Quotient y) {
			return new Quotient(x * y.q);
		}
		static public Quotient operator *( Quotient y, Q1 x) {
			return new Quotient(x * y.q);
		}
		static public Quotient operator *( Quotient x, Quotient y) {
			return new Quotient(x.q * y.q);
		}


		static public Quotient operator *( Quotient y, int x) {
			return new Quotient(x * y.q);
		}
		static public Quotient operator -( Quotient y) {
			return new Quotient(- y.q);
		}


		static public Quotient operator /( Quotient y, Quotient x) {
			return new Quotient(y.q /x.q);
		}

		static public implicit operator Quotient ( Q1 x) {

			return new Quotient(
				new Q(x.numerator,x.denominator)
				
			);
		}

		static public implicit operator Q1 ( Quotient x) {

			return x.q;
		}


		

	}
}
