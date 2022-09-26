
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
	public interface AbsLeOneI
		:nilnul.num.RealI
	{
		nilnul.num.real.be_.absLeOne.vow.Ee realee{ get; }
	}

	public class AbsLeOne :
		num.real.be_.absLeOne.vow.Ee
		, AbsLeOneI
	{

		public nilnul.num.real.be_.absLeOne.vow.Ee realee => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public AbsLeOne(num.RealI val) : base(val)
		{
		}

		public AbsLeOne(nilnul.num.real_.Quotient quotient):this( (RealI)quotient)
		{
		}

		public AbsLeOne(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{
		}

		public AbsLeOne(Quotient1 quotient) : this(new nilnul.num.real_.Quotient(quotient))
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}

	}


}
