using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.cumulus_.cumulaUnis_
{
	public class StreamNew<TCumula, TStream>
		:
		CumulaDefault8Dbl<TCumula>
		where TCumula: num.real.bi.Cumula8dblI,new()
		
		where TStream: real.Stream4dblI,new()
//,
	//	nilnul.obj.stream.Cumulated_cumulatorDefault<RealI, real.StreamI, real.op_.binary.cumulator_.Sum>
	{
		public StreamNew() : base(new TStream())
		{
		}
	}
}
