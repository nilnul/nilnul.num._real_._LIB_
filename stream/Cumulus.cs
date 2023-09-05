using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_.binary.cumulator_;

namespace nilnul.num.real.stream
{
	public class Cumulus
		: nilnul.obj.stream.Cumulated<RealI, real.StreamI, real.op_.binary.CumulatorI>
		,
		real.stream_.SliderI
	{
		public Cumulus(StreamI val,real.op_.binary.CumulatorI folder) : base(val,  folder)
		{
		}
	}


}
