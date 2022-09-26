using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nil.anto_
{
	public class ByInjected4Dbl
		: nilnul.num.real.BeDblI
	{
		public bool be(double obj)
		{
			return !be_.AboutNil4Dbl.Injected.be(obj);
			//throw new NotImplementedException();
		}

		static public ByInjected4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByInjected4Dbl>.Instance;
			}
		}

	}
}
