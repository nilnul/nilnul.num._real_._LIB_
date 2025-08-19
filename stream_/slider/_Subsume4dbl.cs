using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;
using R = System.Double;

namespace nilnul.num.real.stream_.slider
{
	public class Subsume8dbl
		: nilnul.obj.stream_.slider.Subsume2<R, nilnul.num.real.stream_.Slider4dblI, nilnul.num.real.Bi8dblI>
		, real.stream_.Slider4dblI
		,
		Subsume4dblI
	{
		public Subsume8dbl(Slider4dblI val, real.Bi8dblI op) : base(val, op)
		{

		}

		///public double justCumulated => base.boxed.current;
	}

}
