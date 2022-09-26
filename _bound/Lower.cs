using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real._bound
{
	/// <summary>
	/// as lower
	/// </summary>
	public class Lower : nilnul.num.real.Border
		,
		nilnul.obj._bound.LowerI<RealI>
	{


		public Lower(bool v, int mark) : base(v, mark)
		{
		}

		public Lower(bool openFalseCloseTrue, RealI mark) : base(openFalseCloseTrue, mark)
		{
		}

		public Lower(Border border1):this(border1.openFalseCloseTrue,border1.mark)
		{

		}

		

		public override string ToString()
		{
			return nilnul.obj.border._co_.lower._ToTxtX.ToTxt(this);

		}

		static public Lower CreateClose(RealI v) {
			return new Lower(true, v);
		}
	}
}
