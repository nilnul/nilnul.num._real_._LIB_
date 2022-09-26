using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
namespace nilnul.num._real.approach.generator.op_
{
	static public class _ScaleX
		
	{


		static public GeneratorI Scale(this GeneratorI arg, Q scale)
		{
			if (scale==0)
			{
				return new generator_.Quotient();
			}
			return new _scale.Ret(arg,scale);
			//throw new NotImplementedException();
		}

		
	}
}
