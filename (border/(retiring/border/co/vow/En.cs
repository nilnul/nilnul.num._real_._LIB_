using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.border.co.vow
{
	public class En<TVow>
		: nilnul.obj.vow.En<border.Co, TVow>

		where TVow : border.co.VowI, new()

	{
		public En(border.Co val) : base(val)
		{
		}
	}
}
