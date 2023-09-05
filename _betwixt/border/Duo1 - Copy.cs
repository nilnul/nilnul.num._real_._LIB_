using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;
using B = nilnul.num.real.BorderDbl;

namespace nilnul.num.real.border
{
	public class CoDbl
		: 
		nilnul.obj.border.Co<double, BorderDbl>
	{
		public CoDbl(B a, B b) : base(a, b)
		{
		}

		static public CoDbl CreateClose(R x, R y) {

			return new CoDbl(
				B.CreateClose(x)
				, 
				B.CreateClose(y)	
			);
		}

		static public CoDbl CreateOpen(R x, R y) {

			return new CoDbl(
				B.CreateOpen(x)
				, 
				B.CreateOpen(y)	
			);
		}

		static public CoDbl CreateClose(int x, int y) {

			return new CoDbl(
				B.CreateClose(x)
				, 
				B.CreateClose(y)	
			);
		}
	}
}
