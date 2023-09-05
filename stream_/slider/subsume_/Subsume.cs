using nilnul.num.real.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider
{
	

	public class Subsumed : nilnul.obj.stream_.slider.Subsume<RealI, real.stream_.SliderI, num.real.op_.BinaryI>
	{
		public Subsumed(SliderI val, BinaryI op) : base(val, op)
		{
		}
	}

	public class Subsumed_opDefault<TOp> : Subsumed
		where TOp: real.op_.BinaryI,new()
	{
		public Subsumed_opDefault(SliderI val) : base(
			val,
			nilnul.obj_.singleton_.Lazy<TOp>.Instance
		)
		{
		}
	}




}
