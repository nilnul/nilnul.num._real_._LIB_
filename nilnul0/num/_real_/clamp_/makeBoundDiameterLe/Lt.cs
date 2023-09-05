using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num._real_.makeBoundDiameterLe
{
	static public  class _LtX 
		
	{
		
		static public void makeBoundDiameterLt(this MakeBoundDiameterLeI real, Positive1 boundStrictlyShorterThanThis)
		{
			real.makeBoundDiameterLe(boundStrictlyShorterThanThis/2u);
		}

	}

	public abstract class LtA : MakeBoundDiameterLeI
		,
		MakeBoundDiameterLtI
	{
		public abstract void makeBoundDiameterLe(Positive1 boundStrictlyShorterThanThis);
		public void squeeze(Positive1 boundStrictlyShorterThanThis)
		{
			makeBoundDiameterLe(boundStrictlyShorterThanThis/2u);
		}

	}


}
