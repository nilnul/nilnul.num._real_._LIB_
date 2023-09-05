using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_.binary.cumulator_;

namespace nilnul.num.real.stream
{
	public class Cumulus4dbl
		: nilnul.obj.stream.Cumulated<double, real.Stream4dblI, real.of_.binary.Cumulator4dblI>
		,
		real.stream_.Slider4dblI
	{
		public Cumulus4dbl(Stream4dblI val,real.of_.binary.Cumulator4dblI folder) : base(val,  folder)
		{
		}
	}


}
