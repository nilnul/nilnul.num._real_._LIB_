using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.co
{
	/*extern alias obj;*/
	public interface BeI
		:/*obj::*/nilnul.obj.BeI1<nilnul.num.real.Co>
	{
	}

	public abstract class BeA : BeI
	{
		public abstract bool be(RealI a, RealI b);
		public bool be(Co obj)
		{
			return be(obj.Item1,obj.Item2);
		}
	}
}
