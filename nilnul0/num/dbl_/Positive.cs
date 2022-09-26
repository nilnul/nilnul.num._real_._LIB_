using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl_
{
	[Obsolete(nameof(nilnul.num.real_.PositiveDbl))]
	public class Positive : nilnul.num.dbl.vow.En<dbl.be_.positive.Vow>
	{
		public Positive(double val) : base(val)
		{
		}
	}
}
