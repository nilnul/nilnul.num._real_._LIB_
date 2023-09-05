using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co
{
	/*extern alias obj;*/
	public interface Be4dbl_ofTupI
		:
		nilnul.obj.BeI_ofIn<(Border4dblI,Border4dblI)>

		
	{
	}

	public abstract class Be4dbl_ofTupA :
		Be4dbl_ofTupI
		,
		nilnul.obj.BeI1<(Border4dblI,Border4dblI)>
	{
		public abstract bool be(in (Border4dblI, Border4dblI) val);

		public bool be((Border4dblI, Border4dblI) obj)
		{
			return be(in obj);
		}
	}
}
