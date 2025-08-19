using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo.be_
{
	public class NoExtrem
		: BeI
	{
		public bool be(Duo obj)
		{
			return !(obj.Contains(ext_.inf_.Pos.Singleton)  || obj.Contains(ext_.inf_.Neg.Singleton));
		}

		static public readonly NoExtrem Singleton = SingletonByDefault<NoExtrem>.Instance;

	}
}
