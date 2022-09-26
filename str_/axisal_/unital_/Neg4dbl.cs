using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.axisal_.unital_
{
	public class Neg4dbl
		: str.be_.axisal_.unital_.negative.vow.Ee4dbl
	{
		public Neg4dbl(IEnumerable<double> val) : base(val)
		{
		}
		public Neg4dbl(params double [] val):this(
			(IEnumerable<double>) val
		)
		{

		}

		static public IEnumerable<double> _Seq_assumeValid(int _totalLength, int _oneIndex)
		{
			int i = 0;
			for (; i < _oneIndex; i++)
			{
				yield return 0;
			}
			yield return -1;
			i++;
			for ( ; i < _totalLength; i++)
			{
				yield return 0;
			}
		}



	}
}
