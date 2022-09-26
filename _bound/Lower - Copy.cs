using nilnul.num.real.border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real._bound
{
	/// <summary>
	/// as lower
	/// </summary>
	public class LowerDbl : nilnul.num.real.BorderDbl
		,
		nilnul.obj._bound.LowerI<double>
	{
		public LowerDbl(BorderDbl border)    : base(border.openFalseCloseTrue, border.mark)
		{
		}

		public LowerDbl(AsLowerDbl borderDbl1):this(borderDbl1.border)
		{
		}

		public LowerDbl(bool v, int mark) : base(v, mark)
		{
		}

		public LowerDbl(bool openFalseCloseTrue, double mark) : base(openFalseCloseTrue, mark)
		{
		}





		public bool has(double x)
		{
			return lower.be_._HasX.Has(this, x);
		}
		public override string ToString()
		{
			return nilnul.obj.border._co_.lower._ToTxtX.ToTxt(this);

		}
	}
}
