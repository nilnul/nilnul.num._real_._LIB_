using nilnul.num.real.border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real._bound
{
	/// <summary>
	/// as upper
	/// </summary>
	public class UpperDbl : nilnul.num.real.BorderDbl
		,
		nilnul.obj._bound.UpperI<double>
	{
		public UpperDbl(AsUpperDbl borderDbl2):this(borderDbl2.border)
		{
		}

		public UpperDbl(BorderDbl border):base(border.openFalseCloseTrue, border.mark)
		{
		}

		public UpperDbl(bool v, int mark) : base(v, mark)
		{
		}

		public UpperDbl(bool openFalseCloseTrue, double mark) : base(openFalseCloseTrue, mark)
		{
		}

		public bool has(double x)
		{
			return upper.be_._HasX.Has(this, x);
		}

		public override string ToString()
		{
			return nilnul.obj.border._co_.upper._ToTxtX.ToTxt(this);
		}
	}
}
