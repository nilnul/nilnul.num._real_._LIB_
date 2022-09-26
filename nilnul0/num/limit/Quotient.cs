using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.limit
{
	public partial class Quotient
		
		:
		CauchyI
		,
		LimitI
	{
		private Q _val;

		public Q val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Quotient()
			:this(0)
		{

		}
		

		public Quotient(Q val)
		{
			this.val = val;

		}
		public Quotient(Q1 val)
		{
			this.val =(Q) val;

		}

		public Quotient(int x)
		{
			this.val = x;
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

			return new Quotient(x.val + 1);
		}

		static public implicit operator Quotient (int x) {

			return new Quotient(x);
		}


		static public implicit operator Quotient ( Q1 x) {

			return new Quotient(
				new Q(x.numerator,x.denominator)
				
			);
		}

		

		public nilnul.num.quotient.ext.border.duo.be.Bound.Asserted bound
		{
			get
			{

				return nilnul.num.quotient.ext.border.duo.be.Bound.Asserted.CreateSingleton(val);

				throw new NotImplementedException();
			}
		}

		

		public void converge(Positive.Asserted diameter)
		{
			return;
			throw new NotImplementedException();
		}
	}
}
