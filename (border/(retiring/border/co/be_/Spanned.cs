using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R =System.Double;
 
using D = nilnul.num.dbl.border.Co;

namespace nilnul.num.dbl.border.co.be_
{
	public class Spanned : BeI
	{

		public bool be(D obj)
		{
			return  nilnul.num.dbl.Comp.Singleton.Compare(obj.lower.mark, obj.upper.mark) < 0;

		}



		static public Spanned Lazy
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Spanned>.Instance;
			}
		}


	}
}
