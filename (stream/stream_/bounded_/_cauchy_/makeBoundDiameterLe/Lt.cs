using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;

namespace nilnul.num.real.stream_.bounded_._cauchy_.makeBoundDiameterLe
{
	public abstract class LtA : MakeBoundDiameterLeI
		,
		MakeBoundDiameterLtI
	{
		//public abstract void squeeze(Positive1 boundStrictlyShorterThanThis);
		//public void squeeze(Positive1 boundStrictlyShorterThanThis)
		//{
		//	squeeze(boundStrictlyShorterThanThis/2u);
		//}
		public abstract void squeeze(real_.PositiveI diameter);
	}
}
