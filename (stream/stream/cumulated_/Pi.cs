using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._slider_;

namespace nilnul.num.real.stream
{
	public class Pi : nilnul.obj.Box<nilnul.num.real.StreamI>
		,
		nilnul.num.real.stream_.SliderI
	{
		private nilnul.num.Real _accumulated=1;

		public nilnul.num.RealI current
		{
			get { return _accumulated; }
		}

		

		public Pi(StreamI val) : base(val)
		{

		}
		public void moveNext()
		{
			_accumulated *= boxed.next();

		}
		public RealI next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
		}


	}
}
