using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.be_;
using R = nilnul.num.RealI;

namespace nilnul.num.real.to_
{
	static public class _TxtX
	{
		static public string ToTxt(this R x) {
			return nilnul.num._real.approach.to_._TxtX.ToTxt(  x.choice.generate());
		}

		internal static object ToTxt(Positive.En _radius)
		{
			return ToTxt(_radius.val);
		}
	}
}
