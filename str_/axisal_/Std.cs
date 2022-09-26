using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.axisal_
{
	public class Unital4dbl
		: str.be_.axisal_.unital.vow.Ee4dbl
	{
		public Unital4dbl(IEnumerable<double> val) : base(val)
		{
		}
		public Unital4dbl(params double [] val):this(
			(IEnumerable<double>) val
		)
		{

		}

	



	}
}
