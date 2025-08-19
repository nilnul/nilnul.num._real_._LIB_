using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;

namespace nilnul.num.real.op_
{
	public class FroApproachOp
		: real.OpI2
	{
		private nilnul.num._real.approach.OpI _op;

		public nilnul.num._real.approach.OpI op
		{
			get { return _op; }
			set { _op = value; }
		}


		public FroApproachOp(nilnul.num._real.approach.OpI op)
		{
			_op = op;
		}
		public num.RealI2 eval(num.RealI2 arg)
		{
			return new _op.Ret_froApproachOp(arg, _op);

 		}
	}

	public class FroApproachOp<TOp> : FroApproachOp
		where TOp : nilnul.num._real.approach.OpI, new()
	{
		public FroApproachOp() : base(SingletonByDefault<TOp>.Instance)
		{
		}
	}
}
