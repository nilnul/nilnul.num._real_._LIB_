using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.approach.generator.cofinal_
{
	public partial class Quotient
		
		:
		cofinal.eg.Singleton
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
			:base(new generator_.Quotient(val))
		{
			_q = val;
		}

		public Quotient(int x):this((Q) x)
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

		static public Quotient Increment(Quotient x) {

			return new Quotient(x.q+ 1);
		}

		static public implicit operator Quotient (int x) {

			return new Quotient(x);
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

		static public Quotient operator *( Quotient y, int x) {
			return new Quotient(x * y.q);
		}
		static public Quotient operator /( Quotient y, Quotient x) {
			return new Quotient(y.q /x.q);
		}

		static public implicit operator Quotient ( Q1 x) {

			return new Quotient(
				new Q(x.numerator,x.denominator)
				
			);
		}

		

	}
}
