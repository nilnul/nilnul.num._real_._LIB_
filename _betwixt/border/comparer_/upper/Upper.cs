using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.comparer_.upper
{


	public class Decider : nilnul.comparer.decider_.FroStatic1<Border, Upper>
	{


		public bool ge(Border upper, num.RealI x)
		{
			return ge(upper, new Border(true, x));
			//throw new NotImplementedException();
		}

		public bool gt(num.RealI x, Border upper)
		{
			return gt(new Border(true, x), upper);
			//throw new NotImplementedException();
		}


		static public Decider Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Decider>.Instance;
			}
		}


	}

}
