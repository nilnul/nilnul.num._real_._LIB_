using nilnul.num.quotient.bound.op_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.op_.binary_
{
	static public class _MultiX
	{
		static public nilnul.num.real.stream_.SliderI Op(nilnul.num.real.stream_.SliderI x, nilnul.num.quotient.stream_.SliderI1 scale) {
			return unary_._ScaleX.Op(x, scale);
		}

	}

	public class Multi : slider.op_.BinaryI
	{
		public SliderI op(SliderI par, SliderI par1)
		{
			return new _multi.Of(par,par1);
		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}

	}
}
