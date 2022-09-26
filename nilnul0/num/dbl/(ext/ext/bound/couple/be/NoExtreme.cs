
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound.couple.be
{
	public class NoExtreme

	{
		static public bool Eval(Couple couple) {

			return !(
				couple.contains(_ext.Inf.Singleton) || couple.contains(_ext.NegInf.Instance)
				);

			
		}
	}
}
