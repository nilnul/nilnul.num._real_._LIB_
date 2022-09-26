using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.complex.real;

namespace nilnul.math.algebra.function.op
{
	public partial class Divide :DivideI
	{


		public bool isCommutable
		{
			get { return false; }
		}


		public BinaryRealOpExprI call(RealExprI first, RealExprI second)
		{
			return new BinaryRealOpExpr(Instance,first,second);
		}

		public RealExprI simplify(RealExprI firstSimplified, RealExprI secondSimplified)
		{
			if (firstSimplified.GetType().GetGenericTypeDefinition() == typeof(Real<>)

	&&
	secondSimplified.GetType().GetGenericTypeDefinition() == typeof(Real<>)
	)
			{
				Decimal l2 = (Decimal)(firstSimplified.GetType().GetProperty("value").GetValue(firstSimplified, null));
				decimal r2 = (decimal)(secondSimplified.GetType().GetProperty("value").GetValue(secondSimplified, null));
				return (l2 / r2).ToReal();
			}
			else
			{
				throw new Exception();
			}

		}
	}
}
