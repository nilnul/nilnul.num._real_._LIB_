using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.math.algebra.function.op
{
	public partial class Subtract : SubtractI

	{



		public bool isCommutable
		{
			get { return false; }
		}

		#region BinaryRealOpI Members


		public BinaryRealOpExprI call(RealExprI first, RealExprI second)
		{
			return new BinaryRealOpExpr(Instance,first,second);
		}

		public RealExprI simplify(RealExprI a, RealExprI b)
		{
			return Simplify(a,b);
		}

		#endregion
	}

	
}
