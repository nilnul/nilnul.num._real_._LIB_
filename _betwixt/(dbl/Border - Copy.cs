using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl
{
	[Obsolete(nameof(real))]
	public class Border
		: nilnul.obj.Border<double>
	{
		

		public Border(bool openFalseCloseTrue, double mark) : base(openFalseCloseTrue, mark)
		{
		}

		static public Border CreateClose(double mark) {
			return new Border(true, mark);
		}

		static public Border CreateClose(int mark) {
			return new Border(true, mark);
		}

		static public Border CreateOpen(double mark) {
			return new Border(false, mark);
		}
	}
}