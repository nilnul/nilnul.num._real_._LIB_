using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.border.duo.be_
{
	[Obsolete()]
	public class Single : BeI
	{

		static public readonly Single Singleton = SingletonByDefault<Single>.Instance;

		public bool be(Duo obj)
		{

			return num.real.border.Eq.Singleton.Equals(obj.lower , obj.upper);

			throw new NotImplementedException();
		}
	}
}
