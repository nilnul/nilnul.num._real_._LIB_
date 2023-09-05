using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo.be_
{
	public class Single
		: BeI
	{
		public bool be(Duo obj)
		{
			return
				nilnul.border.duo.be_.Single.Be<Border, ExtI>(
					obj
					,ext.Comparer.Singleton
					
					);
			throw new NotImplementedException();
		}

		static public readonly Single Singleton = SingletonByDefault<Single>.Instance;

	}
}
