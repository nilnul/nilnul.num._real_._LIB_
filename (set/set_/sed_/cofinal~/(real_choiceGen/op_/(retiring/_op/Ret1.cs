using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using nilnul.num._real.approach.generator;
using R = nilnul.num.RealI2;

namespace nilnul.num.real._op
{
	public class Ret1<TGeneratorOp>
		: nilnul.num.real.Arg
		,
		R
		where TGeneratorOp : nilnul.num._real.approach.generator.OpI

	{
		private TGeneratorOp _op;

		public TGeneratorOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Ret1(R arg, TGeneratorOp op	) : base(arg)
		{
			_op = op;
		}

		public GeneratorI choice
		{
			get
			{
				return _op.eval(arg.choice);
			}
		}
	}

	public class Ret : Ret1<nilnul.num._real.approach.generator.OpI>
	{
		public Ret(R arg, nilnul.num._real.approach.generator.OpI op) : base(arg,op)
		{
		}
	}

	public class Ret_froApproachOp<TApproachOp> : Ret
		where TApproachOp:nilnul.num._real.approach.OpI
	{
		

		public Ret_froApproachOp(R arg, TApproachOp op)
			:base(
				arg,
				
				new nilnul.num._real.approach.generator.op_.FroApproachOp1<TApproachOp>(op) 
			)
		{

		}
	}

	public class Ret_froApproachOp : Ret
	{
		

		public Ret_froApproachOp(R arg, nilnul.num._real.approach.OpI op)
			:base(
				arg,
				
				new nilnul.num._real.approach.generator.op_.FroApproachOp(op) 
			)
		{

		}
	}

}
