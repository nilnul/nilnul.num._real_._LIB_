using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;

namespace nilnul.num.real.stream_.slider
{
	public class Subsume
		: nilnul.obj.stream_.slider.Subsume<nilnul.num.RealI, nilnul.num.real.stream_.SliderI, nilnul.num.real.op_.BinaryI>
		, real.stream_.SliderI
	{
		public Subsume(SliderI val, BinaryI op) : base(val, op)
		{
		}
	}

}
