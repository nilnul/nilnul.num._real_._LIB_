using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class BorderDbl
		: nilnul.obj.Border<double>
	{
		

		public BorderDbl(bool openFalseCloseTrue, double mark) : base(openFalseCloseTrue, mark)
		{
		}

		static public BorderDbl CreateClose(double mark) {
			return new BorderDbl(true, mark);
		}

		static public BorderDbl CreateClose(int mark) {
			return new BorderDbl(true, mark);
		}

		static public BorderDbl CreateOpen(double mark) {
			return new BorderDbl(false, mark);
		}
	}
}