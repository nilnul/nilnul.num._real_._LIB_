
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.leOne.vow;

namespace nilnul.num.real_
{
	public interface LeOneI
		:nilnul.num.RealI
	{
		nilnul.num.real.be_.leOne.vow.En real{ get; }
	}

	public class LeOne :
		num.real.be_.leOne.vow.En
		, LeOneI
	{

		public nilnul.num.real.be_.leOne.vow.En real => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public LeOne(num.RealI val) : base(val)
		{
		}

		public LeOne(nilnul.num.real_.Quotient quotient):this( (RealI)quotient)
		{
		}

		public LeOne(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{
		}

		public LeOne(Quotient1 quotient) : this(new nilnul.num.real_.Quotient(quotient))
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}

	}


}
