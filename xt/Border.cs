using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.ext
{
	public class Border
		:
		nilnul.Border<ExtI>
		, BorderI
	{
		public Border(bool openFalseCloseTrue, ExtI mark) : base(openFalseCloseTrue, mark)
		{
		}

		static public Border CreateClose(ExtI x) {
			return new Border(true, x);
		}

		static public Border CreateOpen(ExtI x) {
			return new Border(false, x);
		}


		public static Border CreateClose(R lower)
		{
			return CreateClose( new nilnul.num.real.ext_.Bare(lower));
			//throw new NotImplementedException();
		}

		public static Border CreateOpen(R lower)
		{
			return CreateOpen( new nilnul.num.real.ext_.Bare(lower));
			//throw new NotImplementedException();
		}


	}
}
