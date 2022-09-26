using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class Cfg
	{
		static public readonly Cfg Singleton = SingletonByDefault<Cfg>.Instance;

		public string CachePath = "";
	}
}
