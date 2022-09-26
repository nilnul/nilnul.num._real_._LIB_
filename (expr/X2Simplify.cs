using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
//using nilnul.function.op.binary;
using nilnul.collection.set.relation;
using nilnul.math.number.complex.real;

namespace nilnul.math.algebra.function.op
{


	static public class X2Simplify{
		static public RealExprI Simplify(this BinaryRealOpExpr binaryExpr) {
			RealExprI l1 =binaryExpr.first.simplify();
			RealExprI r1 = binaryExpr.second.simplify();
			return binaryExpr.op.simplify(l1,r1);
		}
	}
}
