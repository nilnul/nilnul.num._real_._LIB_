using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;

namespace nilnul.num.real._op
{
	[Obsolete()]
	public class Ret<TGeneratorOp>
		: nilnul.num.real.Arg
		,
		R
		where TGeneratorOp : nilnul.num._real.approach.generator.OpI,new()
	{
		public Ret(R arg) : base(arg)
		{
		}

		public GeneratorI choice
		{
			get
			{
				return SingletonByDefault<TGeneratorOp>.Instance.eval(arg.choice);
				throw new NotImplementedException();
			}
		}
	}

	
}
