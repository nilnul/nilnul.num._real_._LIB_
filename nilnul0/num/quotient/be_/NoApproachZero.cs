using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.quotient.range.be_
{
	/// <summary>
	/// away from zero
	/// </summary>
	public class NoApproachZero
		: BeI
	{
		public bool be(Nonempty.En obj)
		{
			return obj.notContainsZero()
				&& obj.lower.mark !=0
				&&obj.upper.mark !=0
				;
			throw new NotImplementedException();
		}

		public class En : nilnul.num.quotient.range.be.En<NoApproachZero>
		{
			public En(Nonempty.En val) : base(val)
			{
			}
		}
	}
}
