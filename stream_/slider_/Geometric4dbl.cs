using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;

namespace nilnul.num.real.stream_.slider_

{
	public class Geometric4dbl:nilnul.num.real.stream_.Slider4dblA
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


		public Geometric4dbl(R head, R rate)
		{
			_current = head;
			_rate = rate;
		}


		public override void moveNext()
		{
			_current *= _rate;
			//throw new NotImplementedException();
		}
	}
}
