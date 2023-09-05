using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
 
using D = nilnul.num.real.border.Co;

namespace nilnul.num.real.border.co.be_
{
	public class Spanned1 : BeI
	{

		public bool be(D obj)
		{
			return  nilnul.num.real.Comparer.Singleton.Compare(obj.lower.mark, obj.upper.mark) < 0;

		}


		static public Spanned1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Spanned1>.Instance;
			}
		}

	}
}
