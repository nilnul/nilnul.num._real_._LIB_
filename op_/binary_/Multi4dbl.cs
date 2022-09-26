
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rq = nilnul.num.real_.Quotient;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;


namespace nilnul.num.real.op_.binary_
{
	public class Multi4dbl
		: op_.Binary4dblI
	{
		public const char Sign = '*';

		public double  op(double a, double b)
		{
			return a * b;

			
		}

		

		public override string ToString()
		{
			return Sign.ToString();
		}

		static public Multi4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi4dbl>.Instance;
			}
		}
	}
}
