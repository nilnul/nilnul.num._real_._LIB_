using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.doubl.be;

namespace nilnul.num.real.doubl.normal.be
{
	public class GeOne : nilnul.BeI<nilnul.num.doubl.be.Normal.Asserted>
	{
		public bool be(Normal.Asserted obj)
		{
			return obj.val >= 1;
			throw new NotImplementedException();
		}

		public class En:nilnul.be.Asserted<nilnul.num.doubl.be.Normal.Asserted , GeOne>
		{

			public En(
				nilnul.num.doubl.be.Normal.Asserted val
			):base(val)
			{

			}

			public double toDouble() {
				return this.val.val;
			}
		}
	}
}
