using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num._real.approach.op_.uni_
{
	[Obsolete(nameof(_real._cauchy.approach.op_.unary_.Sin))]
	public class Sin
		: nilnul.num._real.approach.op_.UniI
		,
		nilnul.num._real.approach.OpI
	{
		public ApproachI1 eval(ApproachI1 arg)
		{
			return new _sin.Ret(arg);

			//throw new NotImplementedException();
		}

		public static ApproachI1 Eval(Simplify.Ed1 mark)
		{
			return new _sin.ret_.of_.Quotient(mark);
			//throw new NotImplementedException();
		}


		static public readonly Sin Singleton = SingletonByDefault<Sin>.Instance;

	}
}
