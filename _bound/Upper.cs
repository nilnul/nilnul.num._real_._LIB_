using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real._bound
{
	/// <summary>
	/// as upper
	/// </summary>
	public class Upper :
		nilnul.num.real.Border
				,
		nilnul.obj._bound.UpperI<RealI>

	{

		public Upper(bool v, int mark) : base(v, mark)
		{
		}

		public Upper(bool openFalseCloseTrue, RealI mark) : base(openFalseCloseTrue, mark)
		{
		}

		public Upper(Border border2):this(border2.openFalseCloseTrue,border2.mark)
		{

		}

		public override string ToString()
		{
			return nilnul.obj.border._co_.upper._ToTxtX.ToTxt(this);
		}

		static public Upper CreateClose(RealI v) {
			return new Upper(true,v);
		}
	}
}
