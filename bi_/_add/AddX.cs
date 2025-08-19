using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.complex.real;
//using nilnul.function.op.binary;

namespace nilnul.math.algebra.function.op
{
	static public partial class AddX
		
	{
		static public RealExprI AddAndSimplify(this RealExprI firstSimplified,RealExprI secondSimplified)
		{
			if (firstSimplified.GetType().GetGenericTypeDefinition()==typeof(Real<>)
				
				&&
				secondSimplified.GetType().GetGenericTypeDefinition()==typeof(Real<>)
				)
			{
				Decimal l2 = (Decimal)(firstSimplified .GetType().GetProperty("value").GetValue(firstSimplified, null));
				decimal r2 = (decimal)(secondSimplified.GetType().GetProperty("value").GetValue(secondSimplified, null));
				return (l2 + r2).ToReal();
			}

			else
			{
						throw new Exception();
			}

		}
	}
}
