
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.gtOne.vow;

namespace nilnul.num.real_.positive_
{
	public interface NeOneI
		:nilnul.num.RealI
	{

		nilnul.num.real.be_.positive_.neOne.En realen{ get; }

	}

	public class NeOne :
		num.real.be_.positive_.neOne.En
		,
		NeOneI
	{


		public num.real.be_.positive_.neOne.En realen => this;

		public num.quotient.bound_.Closed current => this.realen.ee.current;

		public NeOne(num.RealI val) : base(val)
		{

		}

		public NeOne(nilnul.num.real_.Quotient quotient):this( (RealI)quotient)
		{

		}

		public NeOne(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{

		}

		public NeOne(Quotient1 quotient) : this(new nilnul.num.real_.Quotient(quotient))
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.realen.ee.squeeze(diameter);
		}
	
	}


}
