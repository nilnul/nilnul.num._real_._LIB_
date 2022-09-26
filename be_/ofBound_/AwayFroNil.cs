using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bound_
{
	/// <summary>
	/// the bound is both positve or negative. so we can alread determine the sign of this approach
	/// </summary>
	public class AwayFroNil :num.real.BeI
	{
		public bool be(RealI obj)
		{
			return Negative.Singleton.be(obj) || Positive.Singleton.be(obj);
		}

		static public AwayFroNil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<AwayFroNil>.Instance;
			}
		}

	}
}
