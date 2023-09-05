using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.cumulus_
{
	public class Sum4dbl
		:
		CumulatorDefault4Dbl<real.of_.binary.cumulator_.Sum4dbl>
		,
		stream.Series4dblI
//,
	//	nilnul.obj.stream.Cumulated_cumulatorDefault<RealI, real.StreamI, real.op_.binary.cumulator_.Sum>
	{
		public Sum4dbl(Stream4dblI val) : base(val)
		{
		}
	}
}
