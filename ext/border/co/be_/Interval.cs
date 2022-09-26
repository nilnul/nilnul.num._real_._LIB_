using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo.be_
{
	public class Interval
		: BeI
	{
		public bool be(Duo obj)
		{
			return NonEmpty.Singleton.be(obj) && NoExtrem.Singleton.be(obj);
			throw new NotImplementedException();
		}
	}
}
