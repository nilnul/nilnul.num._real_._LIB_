
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.positive.vow;
using nilnul.obj.stream_._slider._skid_;

namespace nilnul.num.real_
{
	public interface PositiveI_onQuotient
		:
		nilnul.num.real_.NonnegI_onQuotient
		,
		nilnul.num.RealI_onQuotient
	{
		nilnul.num.real.be_.positive.vow.Ee_onQuotient real{ get; }
	}

	public class Positive_onQuotient :
		num.real.be_.positive.vow.Ee_onQuotient
		,
		PositiveI_onQuotient
	{

		public num.real.be_.positive.vow.Ee_onQuotient real => this;

		public (Q4 begin, Q4 end) current => this.eeByRef.current;

		real.be_.nonneg.vow.Ee_onQuotient NonnegI_onQuotient.real =>new num.real.be_.nonneg.vow.Ee_onQuotient(this.eeByRef);

		public Positive_onQuotient(num.RealI_onQuotient val) : base(val)
		{
		}

		public Positive_onQuotient(nilnul.num.real_.Quotient_denomNonnil quotient):this( (RealI_onQuotient)quotient)
		{

		}

		public Positive_onQuotient(int i) : this(
			new nilnul.num.real_.Quotient_denomNonnil(i)
		)
		{

		}

		public Positive_onQuotient(num.quotient_.DenomNonnilI quotient)
			:
			this(new nilnul.num.real_.Quotient_denomNonnil(quotient))
		{
		}

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			
			this.eeByRef.cinch(diameter);
		}
		static public nilnul.num.real_.Negative_onQuotient operator -(Positive_onQuotient positive){
			return new Negative_onQuotient(
				nilnul.num.real.op_.Neg.Singleton.op(positive)
			);
		}

		static public Positive_onQuotient OvAssumePositive(nilnul.num.RealI_onQuotient real) {

			nilnul.num.real_._positive._Clamp_ofAssumePositiveX.CinchTillPositive(real);
			return new Positive_onQuotient(real);
		}


		static public RealI_onQuotient operator *(nilnul.num.quotient_.DenomNonnilI q, Positive_onQuotient p) {
			return nilnul.num.real.op_._ScaleX.Op(q, p);
		}
		static public RealI_onQuotient operator *(Positive_onQuotient p,nilnul.num.quotient_.DenomNonnilI q ) {
			return q * p;
		}


	}


}
