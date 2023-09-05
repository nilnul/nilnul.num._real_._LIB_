using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_.add.cumulator
{
	public class Cumulate4dbl
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<Ext4dblI,Cumulator4dbl>
	{


		static public Cumulate4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate4dbl>.Instance;
			}
		}

	}
}
