using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.real.stream_.slider_.geometric_;

namespace nilnul.num.real.stream_.slider.op_.unary_._scale
{
	public class Of :
		nilnul.num.real.stream_.slider.op_._unary.Ret
		//,
		//nilnul.num.real.stream_.SliderI
	{
		private nilnul.num.quotient.stream_.SliderI1 _scale;

		public nilnul.num.quotient.stream_.SliderI1 scale
		{
			get { return _scale; }
			set { _scale = value; }
		}

		public Of( nilnul.num.quotient.stream_.SliderI1 scale, SliderI arg0) : base(arg0)
		{
			_scale = scale;
		}
		
		public Of( SliderI arg, nilnul.num.quotient.stream_.SliderI1 scale) : this(scale,arg)
		{
		}


		public override num.RealI current => nilnul.num.real.op_.unary_._ScaleX.Op(arg.current,_scale.current);

		public override void moveNext()
		{
			arg.moveNext();
			_scale.moveNext();
		}
	}
}
