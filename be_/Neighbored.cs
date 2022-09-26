using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{
	/// <summary>
	/// given a radius of quotient: r, the real is in (-r, r)
	/// </summary>
	public class Neighbored :
		nilnul.obj.Box<nilnul.num.quotient.bound_.open_.Neighbor>
		,
		nilnul.num.real.BeI
	{
		public Neighbored(num.quotient.bound_.open_.Neighbor val) : base(val)
		{
		}

		public Neighbored(nilnul.num.quotient_.Positive1 radius):this( new nilnul.num.quotient.bound_.open_.Neighbor(radius) )
		{

		}

		public bool be(RealI obj)
		{
			var classed = obj.ToReal();
			return classed < boxed.upper.mark && classed> boxed.lower.mark;
		}
	}
}
