using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.co.be_
{
	public class Lt4dbl
		:
		nonneg.co.Be4dblI
	{
		public bool be(CoDbl obj)
		{
			return obj.component.realee.ee < obj.component1.realee.ee;
			//throw new NotImplementedException();
		}


		static public Lt4dbl Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Lt4dbl>.Instance;
			}
		}
		static public Lt4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Lt4dbl>.Instance;
			}
		}


	}
}
