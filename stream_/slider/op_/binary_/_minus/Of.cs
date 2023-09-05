using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.real.stream_.slider_.geometric_;

namespace nilnul.num.real.stream_.slider.op_.binary_._minus
{
	public class Of :
		nilnul.num.real.stream_.slider.op_._binary.Of
		,
		nilnul.num.real.stream_.SliderI
	{
		public Of(SliderI arg, SliderI arg1) : base(arg, arg1, nilnul.num.real.op_.binary_.Minus.Singleton)
		{
		}
		public Of(SliderI arg, nilnul.num.quotient.stream_.SliderI1 arg1):this(arg, new nilnul.num.real.stream_.slider_.Quotient(arg1))
		{

		}

		

	
	}
}
