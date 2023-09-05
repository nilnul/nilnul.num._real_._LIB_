using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op_.binary_
{
	static public class _ConvolveX
	{
		static public double[] _Convolute_assumesStr(
			IEnumerable<double> a
			,
			IEnumerable<double> b
		) {
			
			var aCount = a.Count();
			var bCount = b.Count();

			if (aCount==0 || bCount==0)
			{
				return new double[0];

			}
			var r = new double[aCount + bCount -1];

			for (int i = 0; i < a.Count(); i++)
			{
	
				for (int j = 0; j < b.Count(); j++)
				{
					r[i + j] += a.ElementAt(i) * b.ElementAt(j);

				}

			}
			return r;
		}
	}
}
