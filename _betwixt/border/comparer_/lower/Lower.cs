using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border.comparer_.lower
{

	public class Re : nilnul.comparer.decider_.FroStatic1<Border, Lower>
	{


		public bool le(Border lower, num.RealI x)
		{
			return le(lower, new Border(true, x));
			//throw new NotImplementedException();
		}

		public bool le(num.RealI x, Border lower)
		{
			return le(new Border(true, x), lower);
		}

		public bool lt(num.RealI x, Border lower)
		{
			return lt(new Border(true, x), lower);
		}


		static public Re Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Re>.Instance;
			}
		}

	}

}

