using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_.binary.cumulator_;

namespace nilnul.num.real.stream
{
	public class Cumulus8dbl1
		: nilnul.obj.stream.Cumulus1<double, real.Stream4dblI, real.bi.Cumula8dblI>
		,
		real.stream_.Slider4dblI
	{
		public Cumulus8dbl1(Stream4dblI val,real.bi.Cumula8dblI folder) : base(val,  folder)
		{
		}
	}


}
