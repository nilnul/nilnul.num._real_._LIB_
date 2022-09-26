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

namespace nilnul.num.real_0
{
	public interface FroEnI
		:nilnul.num.RealI6
	{


	}

	public abstract class Nonneg1<TEn> : 
		FroEnI
		where TEn: nilnul.num.real.vow.EnA
	{
		


		public En real => this;

		public num.quotient.Bound bound => this.en.bound;

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
	}


}
