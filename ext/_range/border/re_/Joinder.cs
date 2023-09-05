using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.re_
{
	public class Joinder : ReI
	{
		public bool re(BorderI a, BorderI b)
		{
			return nilnul.num.real.ext.Eq.Singleton.Equals(a.mark,b.mark) 
				&&
				(a.openFalseCloseTrue != b.openFalseCloseTrue);
			//throw new NotImplementedException();
		}


		static public readonly Joinder Singleton = nilnul.obj.SingletonByDefault<Joinder>.Instance;

	}
}
