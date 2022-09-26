using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;
using B = nilnul.num.dbl.Border;

namespace nilnul.num.dbl.border
{
	public class Co
		: 
		nilnul.obj.border.Co<R, B>
	{
		public Co(B a, B b) : base(a, b)
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
