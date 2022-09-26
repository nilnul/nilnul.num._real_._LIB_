using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.vow
{
	public class En<TVow> : nilnul.obj.vow.En<double, TVow>
		where TVow : VowI,new()
	{
		public En(double val) : base(val)
		{
		}
	}
}
