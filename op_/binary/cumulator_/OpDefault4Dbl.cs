using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;
using R = System.Double;

namespace nilnul.num.real.of_.binary.cumulator_
{
	public class OpDefault4Dbl<TOp>
		:
		nilnul.obj.op_.binary.cumulator_.OpDefault<double,  TOp>
		,Cumulator4dblI

		where TOp : nilnul.num.real.of_.Binary4dblI, new()
	{
		public OpDefault4Dbl(R initial) : base(initial)
		{
		}

	}
	


}
