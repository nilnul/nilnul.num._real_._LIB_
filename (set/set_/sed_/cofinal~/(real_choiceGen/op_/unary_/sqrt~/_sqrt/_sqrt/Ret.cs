using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using nilnul.num._real.approach.generator.op_._negate;

namespace nilnul.num.real.op_._sqrt
{

	[Obsolete(nameof(real_.nonNeg))]
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
				return  nilnul.num._real.approach.generator.op_.Sqrt.Singleton.eval(arg.choice);

				throw new NotImplementedException();
			}
		}
	}
}
