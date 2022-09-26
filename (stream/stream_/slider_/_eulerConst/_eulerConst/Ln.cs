using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._num.bigint.be;
using nilnul.num.type;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using N = nilnul.num._num.bigint.be.Natural.Asserted;
using rQ = nilnul.num.real.Quotient_posConverge2Bounded;

namespace nilnul.num.real.str._eulerConst
{
	/// <summary>
	/// the Ln part; which is to be deleted in eulerConst formula.
	/// </summary>
	public class Ln
		: StrI
	{
		private _num.bigint.be.Natural.Asserted _length;

		public Natural.Asserted length
		{
			get
			{
				return _length;
				throw new NotImplementedException();
			}
		}

	
	public Ln(num._num.bigint.be.Natural.Asserted n)
		{
			_length = n;
		}


		public RealI_posConverge2NonEmpty this[Natural.Asserted index]
		{
			get
			{
				if (index==0)
				{
					return rQ.CreateZero();
				}

				return real.op.Subtract3.Eval( num.real.op.Ln.Eval(index+1 ) , num.real.op.Ln.Eval(index ));

				throw new NotImplementedException();
			}
		}

	

	}
}
