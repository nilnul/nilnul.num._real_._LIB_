using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.limit
{
	public partial class Quotient1
		
		:
		LimitI
	{
		private Q _val;

		public Q val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Quotient1()
			:this(0)
		{

		}
		

		public Quotient1(Q val)
		{
			this.val = val;

		}

		public Quotient1(int x)
		{
			this.val = x;
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

		static public Quotient1 Increment(Quotient1 x) {

			return new Quotient1(x.val + 1);
		}

		static public implicit operator Quotient1 (int x) {

			return new Quotient1(x);
		}


		static public implicit operator Quotient1 ( Q1 x) {

			return new Quotient1(
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
