using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._num.bigint.be;
using nilnul.num.type;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.real.Quotient_posConverge2Bounded;

namespace nilnul.num.real.stream._eulerConst
{
	/// <summary>
	/// the Ln part; which is to be deleted in eulerConst formula.
	/// </summary>
	public class Ln
		: nilnul.num.StreamI4	// StreamI
	{
		

		BigInteger _n=0;

		R _ln_n = Q.CreateZero();


		public Ln()
		{
			
		}

		
		

		public R next()
		{
			var old_ln_n = _ln_n;
			_n++;
			_ln_n = real.op.Ln.Eval(_n);

			return real.op.Subtract3.Eval(_ln_n,old_ln_n) ;

			//throw new NotImplementedException();
		}

		public void reset()
		{
			_n = 0;
			_ln_n = Q.CreateZero();
			return;
			//throw new NotImplementedException();
		}
	}
}
