using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator._op
{
	public class Ret1<TApproachOp>
		: Arg
		,
		GeneratorI
		where TApproachOp: nilnul.num._real.approach.OpI
	{
		private TApproachOp _op;

		public TApproachOp op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Ret1(GeneratorI arg, TApproachOp op) : base(arg)
		{
			_op = op;
		}

		public ApproachI1 generate()
		{
			return _op.eval(arg.generate());
			//throw new NotImplementedException();
		}
	}

	public class Ret:Ret1<approach.OpI>
	{
		public Ret(GeneratorI arg, approach.OpI op):base(arg,op)
		{

		}

	}
}
