using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/*extern alias obj;*/
	public interface BeI
		:
		/*obj::*/nilnul.obj.BeI1<nilnul.num.RealI>

	{
	}

	public abstract class BeA : BeI
	{
		public abstract bool be(Real x);
		public bool be(RealI obj) { return be(new Real(obj)); }
	}
}
