using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_
{
	public class Minus : real.ext.op_.BinaryI
	{




		public ExtI op(ExtI par,ExtI par1)
		{
			return Add.Singleton.op(
				par
				,
				op_.unary_.Neg.Singleton.op(par1)
			);

		}

		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}

	}
}
