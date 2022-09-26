using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num._real_.makeBoundDiameterLt
{

	static public class _LeX

	{

		static public void makeBoundDiameterLt(this MakeBoundDiameterLtI real, Positive1 boundStrictlyShorterThanThis)
		{
			
		}

	}

	public abstract class LeA : MakeBoundDiameterLtI
		,
		MakeBoundDiameterLeI
	{
		public abstract void squeeze(Positive1 boundStrictlyShorterThanThis);
		public void makeBoundDiameterLe(Positive1 boundStrictlyShorterThanThis)
		{
			squeeze(boundStrictlyShorterThanThis);
		}

	}
}
