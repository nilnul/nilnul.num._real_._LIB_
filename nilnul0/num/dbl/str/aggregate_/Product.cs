using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.seq;

namespace nilnul.num.ieee.str.aggregate_
{
	public static class _ProductX
	{
		static public double Product(params double[] a) {
			if (a.None())
			{
				return 1;
			}
			return a.First() * Product(a.Skip(1));
		}

		static public double Product(IEnumerable< double> a) {
			if (a.None())
			{
				return 1;
			}
			return a.First() * Product(a.Skip(1));
		}

	}
}
