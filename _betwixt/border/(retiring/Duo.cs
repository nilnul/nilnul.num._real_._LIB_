using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.border
{
	[Obsolete()]
	public class Duo
		: 
		nilnul.border.Duo1<R, Border>
	{
		public Duo(Border a, Border b) : base(a, b)
		{
		}

		static public Duo CreateClose(R x, R y) {

			return new Duo(
				Border.CreateClose(x)
				, 
				Border.CreateClose(y)	
			);
		}

		static public Duo CreateOpen(R x, R y) {

			return new Duo(
				Border.CreateOpen(x)
				, 
				Border.CreateOpen(y)	
			);
		}

		static public Duo CreateClose(int x, int y) {

			return new Duo(
				Border.CreateClose(x)
				, 
				Border.CreateClose(y)	
			);
		}
	}
}
