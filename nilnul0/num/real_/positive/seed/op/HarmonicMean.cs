using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.positive.seed.op
{
	public class HarmonicMean
	{
		static public double Eval(IEnumerable<double> _seed_allPositive) {

			return _seed_allPositive.Count()
				/
				num.real_.nonnil.str.HarmonicSum.Eval(_seed_allPositive)
			;
		}
	}
}
