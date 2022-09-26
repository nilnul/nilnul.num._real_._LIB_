using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.co.be
{
	public class En<TBe>
		:
		border.Co
		//nilnul.be.Asserted_assertDefaultDiscarded<border.Duo,TBe>

		
		where TBe:nilnul.num.real.border.co.BeI, new()

	{

		public En(border.Co duo):base(duo.lower,duo.upper)
		{
			border.co.be.Vow<TBe>.Singleton.vow(duo);

		}



	}
}
