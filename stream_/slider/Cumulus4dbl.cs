using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.stream_.slider
{
	public class Cumulus4dbl
	:
	nilnul.obj.stream_.slider.Cumulus<R, nilnul.num.real.stream_.Slider4dblI, nilnul.num.real.of_.binary.Cumulator4dblI>
		,
		Cumulus4dblI

	{
		public Cumulus4dbl(Slider4dblI val, nilnul.num.real.of_.binary.Cumulator4dblI fold) : base(val, fold)
		{
		}


	}
}
