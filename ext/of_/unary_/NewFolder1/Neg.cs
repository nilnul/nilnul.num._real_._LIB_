using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.unary_
{
	public class Neg : real.ext.op_.UnaryI
	{
		public ExtI op(ExtI par)
		{
			switch (par)
			{
				case ext_.inf_.Neg neg:
					return ext_.inf_.Pos.Singleton;
				case ext_.Bare bare:
					return new ext_.Bare( nilnul.num.real.op_.unary_.Neg.Singleton.op( bare.val ) );
				//case ext_.inf_.Pos pos:

				default:
					return ext_.inf_.Neg.Singleton;

					break;
			}
			//throw new NotImplementedException();
		}

		static public Neg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Neg>.Instance;
			}
		}

	}
}
