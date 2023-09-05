using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_.min.cumulator
{
	public class Cumulate4dbl
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<double,Cumulator4dbl>
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
