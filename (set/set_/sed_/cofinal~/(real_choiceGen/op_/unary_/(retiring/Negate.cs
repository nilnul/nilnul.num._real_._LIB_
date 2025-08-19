using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using nilnul.num._real.approach.generator.op_._negate;

namespace nilnul.num.real.op_
{
	[Obsolete(nameof(nilnul.num.real.op_.unary_.Neg))]
	public class Negate : OpI2
	{
		static private Lazy<Negate> _lazy = new Lazy<Negate>();
		static public Negate lazy { get { return _lazy.Value; } }

		public R eval(R arg)
		{
			if (arg is nilnul.num.real_.Quotient)
			{
				return -(arg as nilnul.num.real_.Quotient);
			}
			return new Call(arg);

			//throw new NotImplementedException();
		}

		public class Call
			: Arg
			,R
		{
			public Call(R arg) : base(arg)
			{

			}

			public GeneratorI choice
			{
				get
				{
					return new nilnul.num._real.approach.generator.op_._negate.Ret(arg.choice);

					//throw new NotImplementedException();
				}
			}
		}
	}
}
