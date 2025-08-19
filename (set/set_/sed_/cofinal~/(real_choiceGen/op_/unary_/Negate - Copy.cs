using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI3;
using nilnul.num._real.approach.generator.op_._negate;

namespace nilnul.num.real.op_.unary_
{
	[Obsolete()]
	public class Neg : UnaryI1
	{
		static private Lazy<Neg> _lazy = new Lazy<Neg>();
		static public Neg lazy { get { return _lazy.Value; } }

		public R op(R arg)
		{
			if (arg is nilnul.num.real_.Quotient1)
			{
				return -(arg as nilnul.num.real_.Quotient1);
			}
			return new _neg.Ret(arg);

			//throw new NotImplementedException();
		}

		
	}
}
