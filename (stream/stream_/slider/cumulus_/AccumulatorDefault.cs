using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.cumulus_
{
	public class AccumulatorDefault<TAccumulator>
		:
		Cumulus
		where TAccumulator : real.op_.binary.CumulatorI, new()
	{
		public AccumulatorDefault(SliderI val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{
		}
	}
}
