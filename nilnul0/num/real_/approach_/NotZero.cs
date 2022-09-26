using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.range.be_;
using System.Numerics;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.num._real._cauchy.approach.be_.limit_.nonnil.vow;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num._real._cauchy.approach_
{
	/// <summary>
	/// the limit is away from (not adjacent to) zero; so the range''s mark is not zero
	/// </summary>
	public interface NonnilI:A

	{
		nilnul.num._real._cauchy.approach.be_.limit_.nonnil.vow.En nonnil{ get; }
	}

	public class Nonnil : nilnul.num._real._cauchy.approach.be_.limit_.nonnil.vow.En
		,NonnilI
	{
		public Nonnil(A val) : base(val)
		{
		}

		public Nonnil(BigInteger a):this(
			new nilnul.num._real._cauchy.approach_.Quotient(a)
		)
		{
		}

		public En nonnil => this;

		public Range1 range => en.range;

		public void squeeze(quotient_.Positive1 diameter)
		{
			en.squeeze(diameter);
		}
	}



}
