using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using B = nilnul.num.real.Border;

namespace nilnul.num.real.border
{
	public class Co
		: 
		nilnul.obj.border.Co<R, Border>
	{
		public Co(Border a, B b) : base(a, b)
		{
		}

		static public Co CreateClose(R x, R y) {

			return new Co(
				B.CreateClose(x)
				, 
				B.CreateClose(y)	
			);
		}

		static public Co CreateOpen(R x, R y) {

			return new Co(
				B.CreateOpen(x)
				, 
				B.CreateOpen(y)	
			);
		}

		static public Co CreateClose(int x, int y) {

			return new Co(
				B.CreateClose(x)
				, 
				B.CreateClose(y)	
			);
		}
	}
}
