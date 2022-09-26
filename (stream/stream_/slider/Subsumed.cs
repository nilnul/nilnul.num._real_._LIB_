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
	public class Subsume_opDefault<TOp>

		: nilnul.obj.stream_.slider.Subsume_opDefault<nilnul.num.RealI, nilnul.num.real.stream_.SliderI, TOp>
		, real.stream_.SliderI
		where TOp : nilnul.num.real.op_.BinaryI, new()

	{
		public Subsume_opDefault(SliderI val) : base(val)
		{
		}
	}

	public class Subsume_opDefault_add

		: Subsume_opDefault<nilnul.num.real.op_.binary_.Add>

	{
		public Subsume_opDefault_add(SliderI val) : base(val)
		{
		}
	}

}
