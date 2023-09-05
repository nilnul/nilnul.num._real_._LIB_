using nilnul.obj.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.geometric_.std_.rateMiniature
{
	/// <summary>
	/// 1/(1-x) = 1+x+x^2+...
	/// </summary>
	public class Subsumed : nilnul.obj.stream_.slider.Subsume_opDefault_sliderGeneral<RealI, num.real.op_.binary_.Add>
	{
		public Subsumed(RealI val) : base(new Std(val))
		{
		}
	}
}
