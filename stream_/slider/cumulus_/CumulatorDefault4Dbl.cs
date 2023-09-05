using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.cumulus_
{
	public class CumulatorDefault4Dbl<TAccumulator>
		:
		Cumulus4dbl
		where TAccumulator : real.of_.binary.Cumulator4dblI , new()
	{
		public CumulatorDefault4Dbl(Slider4dblI val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{
		}
	}
}
