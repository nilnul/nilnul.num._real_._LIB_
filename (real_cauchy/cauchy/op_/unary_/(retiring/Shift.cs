using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
namespace nilnul.num._real.approach.generator.op_
{
	[Obsolete(nameof(nilnul.num._real.cauchy.op_.unary_._ShiftX))]
	static public class _ShiftX
	{
		static public GeneratorI Shift(this GeneratorI arg, Q shift)
		{
			if (shift==0)
			{
				return new generator_.Quotient();
			}
			return new _shift.Ret(arg,shift);
			//throw new NotImplementedException();
		}
	}

	[Obsolete(nameof(nilnul.num._real.cauchy.op_.unary_.Shift))]
	public class Shift :
		FroApproachOp
		,
		generator.OpI
	{

		
		public Shift(approach.op_.Shift shift):base(shift)
		{
 		}
		public Shift(Q shift)
			:this( new approach.op_.Shift(shift) )
		{
 		}
		
	}
}
