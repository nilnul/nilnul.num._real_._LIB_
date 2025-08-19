using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co
{
	/*extern alias obj;*/
	public interface Be4dblI
		:
		/*obj::*/nilnul.obj.BeI_ofIn<Co4dbl>
		//,
		//nilnul.BeI<Duo>
	{
	}

	public abstract class Be4dblA : Be4dblI
	{
		public abstract bool be(in Co4dbl val);
	}
}
