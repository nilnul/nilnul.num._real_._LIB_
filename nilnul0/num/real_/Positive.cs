
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.positive.vow;

namespace nilnul.num.real_
{
	public interface PositiveI
		:nilnul.num.RealI
	{
		nilnul.num.real.be_.positive.vow.En real{ get; }
	}

	public class Positive :
		num.real.be_.positive.vow.En
		, PositiveI
	{



		public En real => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public Positive(num.RealI val) : base(val)
		{
		}

		public Positive(nilnul.num.real_.Quotient quotient):this( (RealI)quotient)
		{

		}

		public Positive(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{

		}

		public Positive(Quotient1 quotient) : this(new nilnul.num.real_.Quotient(quotient))
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
		static public nilnul.num.real_.Negative operator -(Positive positive){
			return new Negative(
				nilnul.num.real.op_.unary_.Neg.Singleton.op(positive)
			);
		}

		static public Positive OvAssumePositive(nilnul.num.RealI real) {
			nilnul.num.real_._positive._Clamp_ofAssumePositiveX.Void(real);
			return new Positive(real);
		}

		static public nilnul.num.RealI operator *(nilnul.num.QuotientI1 q, Positive p) {
			return nilnul.num.real.op_.unary_._ScaleX.Op(q, p);
		}
		static public nilnul.num.RealI operator *(Positive p,nilnul.num.QuotientI1 q ) {
			return q * p;
		}


	}


}
