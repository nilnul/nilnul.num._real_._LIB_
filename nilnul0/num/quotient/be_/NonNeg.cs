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
	public class NonNeg
		: BeI
	{
		public bool be(Nonempty.En obj)
		{
			return obj.lower.mark >= 0;
				
				
			//throw new NotImplementedException();
		}

		public class En : nilnul.num.quotient.range.be.En<NonNeg>
		{
			public En(Nonempty.En val) : base(val)
			{
			}
		}
	}
}
