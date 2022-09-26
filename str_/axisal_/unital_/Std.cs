using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.axisal_.unital_
{
	public class Std4dbl
		: str.be_.axisal_.unital_.positive.vow.Ee4dbl
	{
		public Std4dbl(IEnumerable<double> val) : base(val)
		{
		}
		public Std4dbl(params double [] val):this(
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
			yield return 1;
			i++;
			for ( ; i < _totalLength; i++)
			{
				yield return 0;
			}
		}



	}
}
