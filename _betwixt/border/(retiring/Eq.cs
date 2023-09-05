using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.border
{
	[Obsolete()]
	public class Eq
		:nilnul.border.Eq_TEqDefault<R, nilnul.num.real.Comparer.Decider,Border>
	{

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

	}
}
