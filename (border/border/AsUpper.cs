using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border
{
	public class AsUpperDbl
		: nilnul.obj.Box1<real.BorderDbl>
		
		

	{
		public AsUpperDbl(BorderDbl val) : base(val)
		{
		}


		public BorderDbl border { get { return boxed; } }


		public override string ToString()
		{
			return $"{boxed.mark}{(boxed.openFalseCloseTrue?']':')')}";
		}

		public string phraseAsInterval()
		{
			return $"(,{ToString()}";
		}
	}
}
