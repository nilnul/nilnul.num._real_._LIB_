using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_.add.cumulator
{
	public class Cumulate
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<
			num.RealI
			,
			add.Cumulator
		>
	{

		static public Cumulate Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate>.Instance;
			}
		}

	}
}
