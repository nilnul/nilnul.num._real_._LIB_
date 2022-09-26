using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.to_.scalar_
{
	static public class _SquareSumX
	{
		static public double SquareSum(IEnumerable<double> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}
		static public float SquareSum(IEnumerable<float> x) {
			return
				nilnul.num.real.co.alesce_.add.Cumulator4float.Singleton.cumulate(
				x.Select(a=>a*a)
			);
		}
		static public decimal SquareSum(IEnumerable<decimal> x) {
			return
				nilnul.num.real.accumulate_._SumX.Eval_byLoop(
				nilnul.num.real.str.convert_.Square.Eval(x)
			);
		}



	}
}
