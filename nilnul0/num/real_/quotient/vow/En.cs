using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.real_.Quotient, TVow>
		where TVow :  nilnul.num.real_.quotient.VowI1, new()
	{
		public En(Quotient val) : base(val)
		{
		}
	}
}
