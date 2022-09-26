using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;




namespace nilnul.num.real.str.co_.sameLen.combine_
{

	public class _MinusX
	{

		static public IEnumerable<double> _Eval(IEnumerable<double> x, IEnumerable<double> y)
		{
			for (int i = 0; i < x.Count(); i++)
			{
				yield return x.ElementAt(i) - y.ElementAt(i);
			}
		}
		static public IEnumerable<decimal> _Eval(IEnumerable<decimal> x, IEnumerable<decimal> y)
		{
			for (int i = 0; i < x.Count(); i++)
			{
				yield return x.ElementAt(i) - y.ElementAt(i);
			}
		}


		static public double[] _Eval(double[] x, double[] y)
		{
			var r = new double[x.Length];
			for (int i = 0; i < x.Count(); i++)
			{
				r[i]= x.ElementAt(i) - y.ElementAt(i);
			}
			return r;
		}







	}
}
