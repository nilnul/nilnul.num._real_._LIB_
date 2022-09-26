using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;

namespace nilnul.num.real.stream_.slider_
{
	public class Quotient
		: nilnul.obj.Box<nilnul.num.quotient.stream_.SliderI1>
		,
		nilnul.num.real.stream_.SliderI
	{
		public Quotient(quotient.stream_.SliderI1 val) : base(val)
		{
		}

		public num.RealI current => new nilnul.num.real_.Quotient(boxed.current);

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

		public RealI next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}
	}

	public class Quotient_ofNew<T> : Quotient
		where T : nilnul.num.quotient.stream_.SliderI1, new()
	{
		public Quotient_ofNew() : base(new T())
		{
		}
	}
}
