using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border_
{
	public class LowerDbl
		: real.BorderDbl
		,
		_border_.HasDblI

	{
		public LowerDbl(bool openFalse, double  val) : base(openFalse, val)
		{
		}

		


		public override string ToString()
		{
			return $"{(openFalseCloseTrue?'[':'(')}{mark}";
		}

		public  string phraseAsInterval()
		{
			return $"{ToString()},{real.ext_.inf_.Pos.CHAR})";
		}
		public  string phraseAsFenced()
		{
			return $"{ToString()},)";
		}

		public bool contain(double element)
		{
			return  element > this.mark || (openFalseCloseTrue  && element == this.mark);
		}
	}
}
