using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.sequence.fibonacci
{
	public partial class Inverse
	{

		static public double Eval(int x) {
			//nfb(i) = round(log(fb(i, 1) * sqrt(5)) / log((1 + sqrt(5)) / 2)) - 1;

			return Math.Round(
				Math.Log(
					nilnul.num.natural.sequence.Fibonacci.Item2((uint)x)
					*Math.Sqrt(5)
				)
				/
 			   Math.Log(
				(1+Math.Sqrt(5))/2
			   )
			)-1;
		
		}

	}
}
