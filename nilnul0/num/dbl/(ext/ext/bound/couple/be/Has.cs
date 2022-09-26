using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound.couple.be
{
	public class Has

	{
		static public bool Eval(Couple couple) {

			var comparedResult = Ord.Singleton.Compare(couple.lower.pinpoint, couple.upper.pinpoint);
			if (ext.Ord.Lt(couple.lower.pinpoint,  couple.upper.pinpoint))
			{
				return true;
				
			}

			if (comparedResult==0)
			{
				return couple.lower.openFalseCloseTrue && couple.upper.openFalseCloseTrue;

			}

			return false;
		}
	}
}
