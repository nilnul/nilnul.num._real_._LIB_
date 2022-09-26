using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.cumulus_
{
	public class Sum
		:
		Cumulus_cumulatorDefault<real.op_.binary.cumulator_.Sum>
//,
	//	nilnul.obj.stream.Cumulated_cumulatorDefault<RealI, real.StreamI, real.op_.binary.cumulator_.Sum>
	{
		public Sum(StreamI val) : base(val)
		{
		}
	}
}
