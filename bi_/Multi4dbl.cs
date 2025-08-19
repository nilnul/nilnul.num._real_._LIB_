
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rq = nilnul.num.real_.Quotient;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using System.Runtime.CompilerServices;


namespace nilnul.num.real.bi_
{
	public class Multi8dbl
		: real.Bi8dblI
	{
		public const char Sign = '*';

		public double  op(double a, double b)
		{
			return a * b;

			
		}

		

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return Sign.ToString();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public  double op(in double par, in double par1)
		{
			return  par * par1;
		}

		static public Multi8dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi8dbl>.Instance;
			}
		}
	}
}
