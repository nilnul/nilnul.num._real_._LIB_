using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.rotation_
{
	public class Acute
	{
		static public real.bound_.Neighbor Neighbor = Create();
		static public real.bound_.Neighbor Create() {
			return new bound_.Neighbor(
				new nilnul.num.real_.Positive(
					nilnul.num.real_.Tau.Singleton.ToReal() / 4
				)
			);
  }
	}
}
