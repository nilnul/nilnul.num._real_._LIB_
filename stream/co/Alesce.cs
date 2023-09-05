using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.co
{
	public class Alesce
		: nilnul.obj.Box<num.real.stream.Co>
		,
		num.real.StreamI
	{
		private num.real.CombineI _combine;

		public num.real.CombineI combine
		{
			get { return _combine; }
			set { _combine = value; }
		}


		public Alesce(nilnul.num.real.stream.Co co, CombineI combine ) : base(co)
		{
			_combine = combine;
		}

		public RealI next()
		{
			return _combine.combine( boxed.Item1.next(),boxed.Item2.next());
		}
	}
}
