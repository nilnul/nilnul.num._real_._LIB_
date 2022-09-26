
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.gtOne.vow;

namespace nilnul.num.real_
{
	public interface GtOneI
		:nilnul.num.RealI
	{

		nilnul.num.real.be_.gtOne.vow.En real{ get; }

	}

	public class GtOne :
		num.real.be_.gtOne.vow.En
		, GtOneI
	{


		public En real => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public GtOne(num.RealI val) : base(val)
		{

		}

		public GtOne(nilnul.num.real_.Quotient quotient):this( (RealI)quotient)
		{

		}

		public GtOne(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{

		}

		public GtOne(Quotient1 quotient) : this(new nilnul.num.real_.Quotient(quotient))
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
		static public nilnul.num.real_.Negative operator -(GtOne positive){
			return new Negative(
				nilnul.num.real.op_.unary_.Neg.Singleton.op(positive)
			);
		}
	}


}
