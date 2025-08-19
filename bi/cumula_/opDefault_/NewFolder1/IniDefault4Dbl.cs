using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;
using R = System.Double;

namespace nilnul.num.real.of_.binary.cumulator_.opDefault_
{
	public class IniDefault4Dbl<TOp>
		:
		nilnul.obj.op_.binary.cumulator_.opDefault_.ElDefault<double,  TOp>
		,Cumulator4dblI

		where TOp : nilnul.num.real.of_.Binary4dblI, new()
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
