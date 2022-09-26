using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N2 = nilnul.Num1;

using Q1 = nilnul.num.Quotient1;
using R = nilnul.num.RealI;
using System.Numerics;
using nilnul.num.real;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.real_.nonneg.op_.unary_._sqrt.ret_
{


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Naming: N is too short. 
	/// </remarks>
	public class OfQuotient
		:
		nilnul.obj._call_.ArgA<Q1>
		,
		nilnul.num.RealI
	{

		public OfQuotient(N2 arg):base(arg)
		{
		}
		
		public OfQuotient(int arg) : this(new N2(arg))
		{
		}

		public OfQuotient(BigInteger arg)
			: this(new N2(arg))
		{
		}

		

		public void clamp(quotient.be_.Positive1.En diameter)
		{

			if (bound.notSpanLessThan(diameter))
			{
				var middle = bound.midPoint;

				var middleSquare =   middle * middle;


				var compareResult = nilnul.num.quotient.Le.Singleton.Compare(
					 nilnul.num.quotient.op.SquareX.Square( middle)
					
					, 

					 arg
				);

				if (compareResult == 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateSingleton(middle);

				
				}
				else if (compareResult < 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(middle,bound.upper.mark);
					
					


				}
				else
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(bound.lower.mark,middle);
					

				}

			}
		
		}

		
	}

}
