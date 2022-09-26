using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.seq;

namespace nilnul.num.ieee.str.aggregate_
{
	public static class _SumX
	{
		static public double Sum(params double[] a) {
			if (a.None())
			{
				return 0;
			}
			return a.First() +Sum(a.Skip(1));
		}

		static public double Sum(IEnumerable< double> a) {
			if (a.None())
			{
				return 0;
			}
			return a.First() + Sum(a.Skip(1));
		}

	}
}
