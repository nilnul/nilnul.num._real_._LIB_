using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;
using R = System.Double;

namespace nilnul.num.real.bi.cumula_.opDefault_
{
	public class IniDefault4Dbl<TOp>
		:
		nilnul.obj.bi.cumula_.opDefault_.ElDefault<double,  TOp>
		,
		real.bi.Cumula8dblI
		

		where TOp : nilnul.num.real.Bi8dblI, new()
	{
		public IniDefault4Dbl() 
		{
		}


		static public IniDefault4Dbl<TOp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<IniDefault4Dbl<TOp>>.Instance;
			}
		}


	}
	


}
