using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_._exp
{


	public class Ret
: Arg
, R
	{
		public Ret(R arg) : base(arg)
		{

		}

		public GeneratorI choice
		{
			get
			{
				return nilnul.num._real.approach.generator.op_.Exp.lazy.eval(arg.choice);

				//throw new NotImplementedException();
			}
		}
		public override string ToString()
		{
			return $"e^({arg})";
		}
	}


}
