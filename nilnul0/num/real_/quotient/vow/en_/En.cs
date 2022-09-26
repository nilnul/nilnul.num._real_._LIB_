using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.real_.Quotient1, TVow>
		where TVow : VowI, new()
	{
		public En(Quotient1 val) : base(val)
		{
		}
	}
}
