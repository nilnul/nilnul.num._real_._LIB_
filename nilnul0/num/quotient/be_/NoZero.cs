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
	public class NoZero
		: BeI
	{
		public bool be(Nonempty.En obj)
		{
			return obj.notContainsZero()
				
				;
			throw new NotImplementedException();
		}

		public class En : nilnul.num.quotient.range.be.En<NoZero>
		{
			public En(Nonempty.En val) : base(val)
			{
			}
		}
	}
}
