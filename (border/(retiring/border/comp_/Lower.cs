using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.border.comp_
{
	public class Lower
		: IComparer<nilnul.num.dbl.Border>
	{
		public int Compare(Border x, Border y)
		{
			var markCompared = dbl.Comp.Singleton.Compare(x.mark, y.mark);

			if (markCompared==0)
			{
				return nilnul.num.quotient.border._comparer.Lower.Singleton.Compare(x.openFalseCloseTrue,y.openFalseCloseTrue);

			}
			else
			{
				return markCompared;
			}
			//throw new NotImplementedException();
		}


		static public Lower Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lower>.Instance;
			}
		}


	}
	
}
