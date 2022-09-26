using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.reals
{
	static public class ExtensionsX
	{
		/*  */
		[Obsolete("sum for double is defined built in")]
		static public double SumObsoleted(this IEnumerable<double> seq) {
			return seq.Sum();
		}

	}
}
