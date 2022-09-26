
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.negative.vow;

namespace nilnul.num.real_
{
	public interface NegativeI
		:nilnul.num.RealI
	{

		nilnul.num.real.be_.negative.vow.En real{ get; }

	}

	public class Negative :
		num.real.be_.negative.vow.En
		, NegativeI
	{


		public En real => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public Negative(num.RealI val) : base(val)
		{

		}

		public Negative(int i) : this(
			new nilnul.num.real_.Quotient(i)
		)
		{

		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
		static public nilnul.num.real_.Positive operator -(Negative x){
			return new Positive(
				nilnul.num.real.op_.unary_.Neg.Singleton.op(x.en)
			);
		}
	}


}
