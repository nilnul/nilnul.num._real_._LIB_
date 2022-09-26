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
	public class Positive : num.real.BeI
	{
		public bool be(RealI obj)
		{
			return obj.current.lower.mark > 0 && obj.current.upper.mark > 0;
		}

		static public Positive Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Positive>.Instance;
			}
		}

	}
}
