using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.real.stream_.slider_.geometric_;

namespace nilnul.num.real.stream_.slider.op_._unary
{
	public abstract class Ret :
		nilnul.num.real.stream_.slider._call.Arg
		,
		nilnul.num.real.stream_.SliderI
	{
		

		public Ret(  SliderI arg0) : base(arg0)
		{
		}

		public abstract RealI current { get; }

		public abstract void moveNext();

		public RealI next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
		}
	}
}
