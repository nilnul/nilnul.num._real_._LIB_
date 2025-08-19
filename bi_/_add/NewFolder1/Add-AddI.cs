using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using nilnul.function.op.binary;
using nilnul.collection.set.relation;
using nilnul.math.number.complex.real;

namespace nilnul.math.algebra.function.op
{


	public partial class Add : AddI
		
	{

		public bool isCommutable
		{
			get { return true; }
		}


		public BinaryRealOpExprI call(RealExprI first, RealExprI second)
		{
			return new BinaryRealOpExpr(Instance,first,second);
		}

		static public RealExprI Call(RealExprI first, RealExprI second) {
			return Instance.call(first, second);
		}



		

		public RealExprI simplify(RealExprI firstSimplified, RealExprI secondSimplified)
		{
			return Simplify(firstSimplified, secondSimplified);
		}

		
	}
}
