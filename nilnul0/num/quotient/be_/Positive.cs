using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.quotient.range.be_
{
	/// <summary>
	/// </summary>
	public class Positive
		: BeI
	{
		public bool be(Nonempty.En obj)
		{
			return nilnul.num.quotient.border.comparer_.lower.Decider1.Singleton.gt(obj.lower, new Border1(true,0));
				
				
			//throw new NotImplementedException();
		}

		public class En : nilnul.num.quotient.range.be.En<Positive>
		{
			public En(Nonempty.En val) : base(val)
			{
			}
		}
	}
}
