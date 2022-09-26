using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.quotient.Q;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.real
{
	[Obsolete()]
	public  class Quotient_posConverge2Bounded
		
		:
		RealI_posConverge2NonEmpty		
	{
		private R _val;

		public R val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Quotient_posConverge2Bounded()
			:this(0)
		{

		}
		

		public Quotient_posConverge2Bounded(R val)
		{
			this.val = val;

		}

		public Quotient_posConverge2Bounded(int x)
		{
			this.val = x;
		}
	
	

		

		static public Quotient_posConverge2Bounded NewZero() {
			return new Quotient_posConverge2Bounded(0);
		}
		static public Quotient_posConverge2Bounded CreateZero() {
			return new Quotient_posConverge2Bounded(0);
		}

		static public Quotient_posConverge2Bounded CreateOne() {
			return new Quotient_posConverge2Bounded(1);
		}

		static public Quotient_posConverge2Bounded Increment(Quotient_posConverge2Bounded x) {

			return new Quotient_posConverge2Bounded(x.val + 1);
		}

		static public implicit operator Quotient_posConverge2Bounded (int x) {

			return new Quotient_posConverge2Bounded(x);
		}



		public rational.bound.pair.be.Nonempty.Asserted interval
		{
			get {

				return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.CreateSingleton(val);
				
				throw new NotImplementedException(); 
			
			}
		}

		public void converge(rational.be.Positive.Asserted span)
		{
			return;

			throw new NotImplementedException();
		}
	}
}
