using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo.be_
{
	public class Spanned
		: BeI
	{
		public bool be(Duo obj)
		{
			return nilnul.num.real.ext.Comparer.Decider.Singleton.lt(obj.lower.mark, obj.upper.mark);

			throw new NotImplementedException();
		}


		static public readonly Spanned Singleton = SingletonByDefault<Spanned>.Instance;

	}
}
