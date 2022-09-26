using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow
{
	public class EeOfDouble<TVow>
		:
		nilnul.obj.vow.ee_.Defaultable<double, TVow>
		where TVow : nilnul.num.real.VowOfDoubleI, new()
	{
		public EeOfDouble(double val) : base(val)
		{
		}
	}
}
