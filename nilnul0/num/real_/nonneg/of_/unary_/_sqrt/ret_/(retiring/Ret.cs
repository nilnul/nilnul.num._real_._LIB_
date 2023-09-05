using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using nilnul.num._real.approach.generator.op_._negate;
using nilnul.num._real.approach.generator_;

namespace nilnul.num.real_.nonNeg._sqrt
{


	public class Ret
		: Arg
		, NonNegI
	{
		public Ret(NonNegI arg) : base(arg)
		{

		}

		public Ret(R real)
			:this(
				 new NonNeg(real)
				 )
		{

		}

		public GeneratorI choice
		{
			get
			{
				return  nilnul.num._real.approach.generator.op_.Sqrt.Singleton.eval(arg.choice);

				//throw new NotImplementedException();
			}
		}

		_real.approach.generator_.NonNegI NonNegI.choice
		{
			get
			{
				return new _real.approach.generator_.NonNeg(choice);

				//throw new NotImplementedException();
			}
		}
	}
}
