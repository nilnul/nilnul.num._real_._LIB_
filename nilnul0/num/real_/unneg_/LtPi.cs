using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg_
{
	public class LtPi
		:
		nilnul.num.real.be_.nonneg_.ltPi.vow.Ee
		,
		nilnul.num.real_.NonnegI
	{
		public LtPi(RealI val) : base(val)
		{
		}

		public En realee => new En(this);

		public Closed current => this.en.current;

		public void squeeze(Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
	}
}
