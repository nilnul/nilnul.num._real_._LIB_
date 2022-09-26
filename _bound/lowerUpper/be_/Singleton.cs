using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be_
{
	public class Single1
		:
		nilnul.obj._bound.lowerUpper.be_.single_.EqDefault<
			RealI,
			_bound.Lower
			,
			_bound.Upper
			,
			nilnul.num.real.Eq
		>
		,
		lowerUpper.BeI
	{
		public bool be(LowerUpper obj)
		{
			return base.be(obj);
		}

		static public Single1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Single1>.Instance;
			}
		}

	}
}
