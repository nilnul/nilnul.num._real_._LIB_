using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public class BagOfDbl : nilnul.obj.bag_.EqDefault<double, num.real.EqDbl>
	{
		public BagOfDbl()
		{
		}

		public BagOfDbl(IEnumerable<double> keysInMultiples) : base(keysInMultiples)
		{
		}

		public BagOfDbl(IEnumerable<KeyValuePair<double, NumI1>> keyValuePairs) : base(keyValuePairs)
		{
		}

		public BagOfDbl(IEnumerable<KeyValuePair<double, Num1>> keyValuePairs) : base(keyValuePairs)
		{
		}
	}
}
