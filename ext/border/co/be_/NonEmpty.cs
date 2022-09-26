using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo.be_
{
	public class NonEmpty :
		BeI
	{
		public bool be(Duo obj)
		{
			return Spanned.Singleton.be(obj) || Single.Singleton.be(obj);

			//throw new NotImplementedException();
		}


		static public readonly NonEmpty Singleton = SingletonByDefault<NonEmpty>.Instance;

			
		public class En
			: nilnul.be.Asserted_assertDefaultDiscarded<Duo, NonEmpty>
		{
			public En(Duo val) : base(val)
			{
			}
		}
	}
}
