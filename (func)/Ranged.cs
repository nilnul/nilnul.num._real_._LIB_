using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Range__ = nilnul.num.real.double_.noNaN.range.b.Bounded.Asserted;

namespace nilnul.num.real.func
{
	public class Ranged
	{
		private Range__ _range;

		public Range__ range
		{
			get { return _range; }
			set { _range = value; }
		}

		private Func<double,double> _func;

		public Func<double,double> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Ranged(Range__ range, Func<double,double> func)
		{
			_range = range;_func = func;
		}

		static public Ranged CreateClosedRange(
			double begin,double end, Func<double,double> func	
			) {

			return new Ranged(
				Range__.CreateClose(
					begin,end
					
				)	
				,func
			);

		}

	}
}
