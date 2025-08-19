using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op_._cube
{


	public class Call : Arg
		,
		GeneratorI
	{
		public Call(GeneratorI arg) : base(arg)
		{
		}

		public ApproachI1 generate()
		{
			return new nilnul.num._real.approach.op_._cube.Call(arg.generate());
			//todo
			throw new NotImplementedException();
		}

	}
	
}
