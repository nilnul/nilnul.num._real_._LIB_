﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.realNumber
{
	public class NegateExpr
		: UnaryOpExprA<ExprI<RealI>>
		, NegateExprI
	{
		public NegateExpr(ExprI<RealI> a)
			:base(a)
		{
			
		}



		#region RealI Members

		public ExprI<RealI> simplify()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable Members

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
