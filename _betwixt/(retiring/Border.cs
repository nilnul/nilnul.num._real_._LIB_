using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R= nilnul.num.RealI2;

namespace nilnul.num.real
{
	[Obsolete()]
	public class Border
		: Border<R>
		
	{

		public Border(bool v, int mark)
			:this(
				 v,

				 new nilnul.num.real_.Quotient(mark)
				 )
		{
			
		}

		public Border(bool openFalseCloseTrue, R mark) : base(openFalseCloseTrue, mark)
		{

		}

		static public Border CreateClose(R mark) {
			return new Border(true, mark);
		}

		static public Border CreateClose(int mark) {
			return new Border(true, mark);
		}


		static public Border CreateOpen(R mark) {
			return new real.Border(false, mark);
		}
		
	}


}
