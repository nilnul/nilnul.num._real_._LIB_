using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.border.comp_
{
	public class Upper
		: IComparer<nilnul.num.dbl.Border>
	{
		public int Compare(Border x, Border y)
		{
			var markCompared = dbl.Comp.Singleton.Compare(x.mark, y.mark);
			if (markCompared==0)
			{
				return nilnul.num.quotient.border._comparer.Upper.Singleton.Compare(x.openFalseCloseTrue,y.openFalseCloseTrue);

			}
			else
			{
				return nilnul.num.dbl.Comp.Singleton.Compare(x.mark, y.mark);
			}
			//throw new NotImplementedException();
		}


		static public Upper Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Upper>.Instance;
			}
		}

	}
}
