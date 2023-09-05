using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num._real.approach.op_.uni_
{
	public class Cos
		: nilnul.num._real.approach.op_.UniI
		,
		nilnul.num._real.approach.OpI
	{
		public ApproachI1 eval(ApproachI1 arg)
		{
			if (arg is nilnul.num._real.approach_.Quotient)
			{
				var argAsQ = arg as nilnul.num._real.approach_.Quotient;

				if (argAsQ.quotient==0)
				{
					return new nilnul.num._real.approach_.Quotient(1);

				}

				return new _cos.of_.Quotient(argAsQ.quotient);
			}
			return new _cos.Of(arg);

			//throw new NotImplementedException();
		}

		public static ApproachI1 Eval(Simplify.Ed1 mark)
		{
			if (mark == 0)
			{
				return new nilnul.num._real.approach_.Quotient(1);

			}

			return new _cos.of_.Quotient(mark);
			//throw new NotImplementedException();
		}



		static public readonly Cos Singleton = SingletonByDefault<Cos>.Instance;

	}
}
