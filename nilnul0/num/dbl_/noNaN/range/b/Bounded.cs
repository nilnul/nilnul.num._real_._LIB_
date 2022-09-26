using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.double_.noNaN.border.duo.b;

namespace nilnul.num.real.double_.noNaN.range.b
{
	public class Bounded
		: nilnul.obj.BI<border.duo.b.Has.Asserted>
	{
		public bool be(Has.Asserted d)
		{
			return !( d.contains(double.PositiveInfinity) || d.contains(double.NegativeInfinity) );
			throw new NotImplementedException();
		}


		public void assertContains(double x) {
			
		}

		public class Asserted:nilnul.obj.Asserted<Has.Asserted,Bounded>
		{
			public Asserted( Has.Asserted has):base(has)
			{

			}

			static public Asserted CreateClose(double a, double b) {
				return new Asserted(
					new Has.Asserted(a, true, b, true)
				);

			}

		}
	}
}
