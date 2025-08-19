using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.subsume_.opDefault_
{
	public class StreamNew<TCumula, TStream>
		:
		OpDefault8Dbl<TCumula>

		where TCumula: nilnul.num.real.Bi8dblI,new()
		where TStream: real.stream_.Slider4dblI,new()
//,
	//	nilnul.obj.stream.Cumulated_cumulatorDefault<RealI, real.StreamI, real.op_.binary.cumulator_.Sum>
	{
		public StreamNew() : base(new TStream())
		{
		}
	}
}
