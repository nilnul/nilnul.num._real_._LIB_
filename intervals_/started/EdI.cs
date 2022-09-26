using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.intervals_.started
{
	public class Ed<TVow>
		:
		nilnul.obj.vow.Ed<intervals_.Started, TVow>
		where TVow : nilnul.num.real.intervals_.started.VowI,new()
	{
		public Ed(Started val) : base(val)
		{
		}
	}
}
