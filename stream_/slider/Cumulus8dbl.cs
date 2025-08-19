using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.stream_.slider
{
	public class Cumulus8dbl
	:
	nilnul.obj.stream_.slider.Cumulus2<R, nilnul.num.real.stream_.Slider4dblI, nilnul.num.real.bi.Cumula8dblI>
		,
		Cumulus4dblI

	{
		public Cumulus8dbl(Slider4dblI val, nilnul.num.real.bi.Cumula8dblI fold) : base(val, fold)
		{
		}


	}
}
