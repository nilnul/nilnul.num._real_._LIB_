using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	public class Alter
		: nilnul.num.real.stream_.slider._call.Arg
		,
		nilnul.num.real.stream_.SliderI
	{
		private nilnul.bit.slider_.Alter _alter = new bit.slider_.Alter(false);
		public Alter(SliderI arg) : base(arg)
		{
		}

		public num.RealI current => _alter.current? nilnul.num.real.op_.unary_.Neg.Singleton.op( arg.current): arg.current;

		public void moveNext()
		{
			_alter.moveNext();
			arg.moveNext();

			//throw new NotImplementedException();
		}

		public RealI next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
		}
	}
}
