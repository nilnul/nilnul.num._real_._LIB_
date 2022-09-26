using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;

namespace nilnul.num.real.eg
{
	public class SilverRatio : RealI_posConverge2NonEmpty
	{
		private RealI_posConverge2NonEmpty _expr;

		public SilverRatio()
		{
			_expr = op.Add_posConverge2bounded.Eval(1,new op.Sqrt.CallOfN(2));
		}

		public Nonempty.Asserted interval
		{
			get
			{
				return _expr.interval;
				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{
			_expr.converge(diameter);

			throw new NotImplementedException();
		}
	}
}
