using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.op_.binary_.multi
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.Accumulator_opDefault<nilnul.num.real.stream_.SliderI, nilnul.num.real.stream_.slider.op_.binary_.Multi>
	{
		public Cumulator() : base(new nilnul.num.real.stream_.slider_.quotient_.Repeater(1))
		{
		}

		static public Cumulator Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
