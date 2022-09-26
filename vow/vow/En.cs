using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real._cauchy.approach.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num._real._cauchy.ApproachI, TVow>
		where TVow : nilnul.num._real._cauchy.approach.VowI, new()
	{
		public En(ApproachI val) : base(val)
		{
		}
	}
}
