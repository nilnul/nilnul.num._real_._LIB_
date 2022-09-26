using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._bound.lowerUpper.be_
{
	public class Spanned
		: nilnul.obj._bound.lowerUpper.be_.Spanned_OnDenseObj<RealI, Lower, Upper>
	{
		public Spanned() : base(num.real.Comparer.Singleton)
		{
		}

		static public Spanned Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Spanned>.Instance;
			}
		}

	}
}
