using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.op_.unary_._prod
{
	public class Ret : nilnul.obj.Box<nilnul.num.real.StreamI>
		,
		nilnul.num.real.StreamI
	{
		private nilnul.num.Real _accumulated=1;

		public nilnul.num.Real accumulated
		{
			get { return _accumulated; }
			set { _accumulated = value; }
		}

		public Ret(StreamI val) : base(val)
		{

		}

		public RealI next()
		{
			_accumulated *= boxed.next();
			return _accumulated;

			//throw new NotImplementedException();
		}

		//public void reset()
		//{
		//	_accumulated = 1;
		//	boxed.reset();
		//	//throw new NotImplementedException();
		//}
	}
}
