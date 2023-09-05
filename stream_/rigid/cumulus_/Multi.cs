using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._slider_;

namespace nilnul.num.real.stream_.rigid.cumulus_
{
	public class Multi : real.stream.cumulus_.Prod

	{
		public Multi(RealI val) : base(new real.stream_.Rigid(val))
		{
		}
		public nilnul.num.RealI item { get {
				return ( (real.stream_.Rigid)(this.boxed)).item;
			}
		}
	}
}
