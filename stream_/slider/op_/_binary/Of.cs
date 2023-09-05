using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.real.stream_.slider_.geometric_;

namespace nilnul.num.real.stream_.slider.op_._binary
{
	public class Of :
		nilnul.num.real.stream_.slider._call.ArgArg1
		,
		nilnul.num.real.stream_.SliderI
	{
		public Of(SliderI arg, SliderI arg1, nilnul.num.real.op_.BinaryI op) : base(arg, arg1)
		{
			_op = op;
		}
		public Of(SliderI arg, nilnul.num.quotient.stream_.SliderI1 arg1, nilnul.num.real.op_.BinaryI op):this(arg, new nilnul.num.real.stream_.slider_.Quotient(arg1), op)
		{

		}

		private nilnul.num.real.op_.BinaryI _op;

		public nilnul.num.real.op_.BinaryI op
		{
			get { return _op; }
			//set { _op = value; }
		}


		public num.RealI current => _op.op(arg.current,arg1.current);

		public void moveNext()
		{
			arg.moveNext();
			arg1.moveNext();
		}

		public RealI next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}
}
