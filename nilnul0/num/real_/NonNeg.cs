using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;

namespace nilnul.num.real_
{
	[Obsolete()]
	public interface NonnegI
		:nilnul.num.RealI6
	{
		nilnul.num.real.be_.nonneg.vow.En real{ get; }
	}

	[Obsolete()]
	public class Nonneg : num.real.be_.nonneg.vow.En
		,NonnegI
	{

		public Nonneg(num.RealI6 val) : base(val)
		{
		}

		public En real => this;

		public num.quotient.Bound bound => this.en.bound;

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
	}


}
