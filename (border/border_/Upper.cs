using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border_
{
	public class UpperDbl
		: real.BorderDbl
		,
		_border_.HasDblI

	{
		public UpperDbl(bool openFalse, double  val) : base(openFalse, val)
		{
		}




		public override string ToString()
		{
			return $"{mark}{(openFalseCloseTrue ? ']' : ')')}";
		}

		public string phraseAsInterval()
		{
			return $"({real.ext_.inf_.Neg.TXT},{ToString()}";
		}

		public string phraseAsFenced()
		{
			return $"(,{ToString()}";
		}


		public bool contain(double element)
		{
			return  element < this.mark || (openFalseCloseTrue  && element == this.mark);
		}
	}
}
