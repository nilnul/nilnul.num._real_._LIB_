using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.ext_
{
	public class Bare
		: nilnul.ext_.Bare<R>
		,
		ExtI
	{
		public Bare(R val) : base(val)
		{
		}
		public Bare(nilnul.num.real_.Quotient q):this(
			(R)q
		)
		{
				
		}

		public Bare(nilnul.num.QuotientI q):this(
			new nilnul.num.real_.Quotient(q)
		)
		{

		}
		public Bare(nilnul.num.Quotient1 q):this(
			(nilnul.num.QuotientI)(q)
		)
		{

		}

		public Bare(int x):this(new nilnul.num.Quotient1(x))
		{

		}

		
	}
}
