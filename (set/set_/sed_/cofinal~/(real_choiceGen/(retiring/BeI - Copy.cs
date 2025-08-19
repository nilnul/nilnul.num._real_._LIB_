using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	[Obsolete()]
	/*extern alias obj;*/
	public interface BeI
		:nilnul.BeI<nilnul.num.RealI2>
		,
		/*obj::*/nilnul.obj.BeI1<nilnul.num.RealI2>

	{
	}
}
