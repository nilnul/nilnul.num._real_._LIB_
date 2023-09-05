using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI2;
 using nilnul.num.real.all;


namespace nilnul.num.real.border.duo.be_
{
	[Obsolete()]
	public class Spanned : BeI
	{

		static public readonly Spanned Singleton = SingletonByDefault<Spanned>.Instance;

		public bool be(Duo obj)
		{
			return SingletonByDefault< nilnul.num.real.Comparer>.Instance.Compare(obj.lower.mark, obj.upper.mark) < 0;

			throw new NotImplementedException();
		}

		public class En : be.En<Spanned>
		{
			public En(Duo duo) : base(duo)
			{

			}

			
		}
	}
}
