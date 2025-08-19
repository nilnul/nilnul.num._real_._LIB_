using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.accumulate_
{
	public class SquareSum
	{
		static public double Eval(IEnumerable<double> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}
		static public decimal Eval(IEnumerable<decimal> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}


	}
}
