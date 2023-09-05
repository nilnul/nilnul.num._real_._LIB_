using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_
{
	public class Geometric:nilnul.num.real.stream_.SliderA
	{
		private R _current;

		public override R current
		{
			get { return _current; }
			//set { _current = value; }
		}

		private R _rate;

		public R rate
		{
			get { return _rate; }
			set { _rate = value; }
		}


		public Geometric(R head, R rate)
		{
			_current = head;
			_rate = rate;
		}

		public override void moveNext()
		{
			_current = nilnul.num.real.op_.binary_.Multi.Singleton.op(_current, _rate);
			//throw new NotImplementedException();
		}
	}
}
