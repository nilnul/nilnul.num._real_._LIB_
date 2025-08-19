using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.op_
{
	public class FroApproachOp1<TApproachOP>
		: OpI
		where TApproachOP : nilnul.num._real.approach.OpI
	{
		private TApproachOP _op;

		public TApproachOP op
		{
			get { return _op; }
			set { _op = value; }
		}

		public FroApproachOp1( TApproachOP op)
		{
			_op = op;
		}
		public GeneratorI eval(GeneratorI arg)
		{
			return new _op.Ret1<TApproachOP>(arg,_op);
		}
	}

	public class FroApproachOp : FroApproachOp1<approach.OpI>
	{
		public FroApproachOp(approach.OpI op) : base(op)
		{
		}
	}
}
