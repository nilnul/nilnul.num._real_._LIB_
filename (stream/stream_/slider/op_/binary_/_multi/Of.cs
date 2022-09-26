using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.real.stream_.slider_.geometric_;

namespace nilnul.num.real.stream_.slider.op_.binary_._multi
{
	public class Of : nilnul.num.real.stream_.slider._call.ArgArg1
		,
		nilnul.num.real.stream_.SliderI
	{
		public Of(SliderI arg, SliderI arg1) : base(arg, arg1)
		{
		}
		public Of(SliderI arg, nilnul.num.quotient.stream_.SliderI1 arg1):this(arg, new nilnul.num.real.stream_.slider_.Quotient(arg1))
		{

		}

		

		public num.RealI current => nilnul.num.real.op_.binary_.Multi.Singleton.op(arg.current,arg1.current);

		public void moveNext()
		{
			arg.moveNext();
			arg1.moveNext();
		}

		public RealI next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
		}
	}
}
