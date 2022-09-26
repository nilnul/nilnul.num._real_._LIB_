using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be
{
	public class En
		: nilnul.obj.be.En4<nilnul.num.real._bound.LowerUpper>
	{
		public En(LowerUpper obj, BeI1<LowerUpper> be) : base(obj, be)
		{
		}

		public En(LowerUpper obj, Predicate<LowerUpper> predicate) : base(obj, predicate)
		{
		}

		public En(LowerUpper obj, Func<LowerUpper, bool> predicate) : base(obj, predicate)
		{
		}
	}
}
