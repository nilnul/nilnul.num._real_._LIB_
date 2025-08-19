using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op_._sqrt
{


	public class Ret : Arg
		,
		GeneratorI
	{
		public Ret(GeneratorI arg) : base(arg)
		{

		}

		public ApproachI1 generate()
		{
			return  nilnul.num._real.approach.op_.Sqrt.Eval(arg.generate());
			//todo
			throw new NotImplementedException();
		}


	

	}
}
