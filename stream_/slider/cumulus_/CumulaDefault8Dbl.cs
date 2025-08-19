using nilnul.num.real.op_.binary;
using nilnul.num.real.stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.cumulus_
{
	public class CumulaDefault8Dbl<TAccumulator>
		:
		slider.Cumulus8dbl
		where TAccumulator : real.bi.Cumula8dblI, new()
	{
		public CumulaDefault8Dbl(Slider4dblI val) : base(val, nilnul.obj_.Singleton<TAccumulator>.Instance)
		{
		}
	}
}
