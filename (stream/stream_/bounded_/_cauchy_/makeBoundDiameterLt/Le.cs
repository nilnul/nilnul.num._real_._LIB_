using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.real.stream_.bounded_._cauchy_.makeBoundDiameterLt
{
	public abstract class LeA :
		MakeBoundDiameterLtI
		,
		MakeBoundDiameterLeI
	{
		//public abstract void squeeze(Positive1 boundStrictlyShorterThanThis);
		//public void squeeze(Positive1 boundStrictlyShorterThanThis)
		//{
		//	squeeze(boundStrictlyShorterThanThis);
		//}
		public abstract void squeeze(real_.PositiveI diameter)
		;
	}
}
