using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;
using nilnul.num._real.limit.sow;
using R = nilnul.num.real_.NotZeroI;


namespace nilnul.num.real_.notZero.op_._inverse
{

	[Obsolete()]
	public class Call : nilnul._call.ArgA<R>, R
	{
		public Call(R x) : base(x)
		{

		}

		public _real.approach.generator_.NotZeroI choice
		{
			get
			{
				return _real.approach.generator_.notZero.op_.Inverse.Singleton.eval(arg.choice);

				throw new NotImplementedException();
			}
		}

		GeneratorI CofinalI.choice
		{
			get
			{
				return choice;
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return $"1/({arg})";
		}
	}

}
