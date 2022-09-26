using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be_
{
	public class Dwelt
		:
		nilnul.obj._bound.lowerUpper.be_.dwelt_.ComparerDefault_OnDenseObj
		<
			RealI, Lower, Upper, real.Comparer
		>
		,
		lowerUpper.BeI
	{
		public bool be(LowerUpper obj)
		{
			return base.be(obj);
		}

		static public Dwelt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dwelt>.Instance;
			}
		}

	}
}
