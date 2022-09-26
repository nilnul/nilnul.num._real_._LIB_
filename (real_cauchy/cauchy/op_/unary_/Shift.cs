using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI3;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using C = nilnul.num._real.CauchyI2;
namespace nilnul.num._real.cauchy.op_.unary_
{
	static public class _ShiftX
	{
		static public C Shift( Q1 shift, C arg)
		{
			if (shift==0)
			{
				return new cauchy_.Quotient( shift);
			}
			return new _shift.Ret(shift,arg);
			//throw new NotImplementedException();
		}
	}

	public class Shift 
		:nilnul.obj.Box<Q1>
		,UnaryI
	{

		
		public Shift(Q1 shift):base(shift)
		{

 		}

		public C op( C par)
		{
			return _ShiftX.Shift(boxed,par);

		}
	}
}
