using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;
using R = System.Double;

namespace nilnul.num.real.stream_.slider
{
	public class _Subsume4dbl
		: nilnul.obj.stream_.slider.Subsume<R, nilnul.num.real.stream_.Slider4dblI, nilnul.num.real.of_.Binary4dblI>
		, real.stream_.Slider4dblI
		,
		Subsume4dblI
	{
		public _Subsume4dbl(Slider4dblI val, real.of_.Binary4dblI op) : base(val, op)
		{

		}

		public double justCumulated => base.boxed.current;
	}

}
