using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op
{




	public static class X
	{

		static public GeneratorI Sqrt(this GeneratorI x)
		{
			return op_.Sqrt.Singleton.eval(x);
		}


		static public GeneratorI Negate(this GeneratorI x)
		{
			return  op_.Negate.Singleton.eval(x);
		}




	}


}
