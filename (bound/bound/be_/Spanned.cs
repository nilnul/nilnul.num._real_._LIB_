using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound.be_
{
	public class Spanned
		: num.real.bound.BeI
	{
		public bool be(BoundI obj)
		{


			return obj.lower.mark.ToReal() < obj.upper.mark;
			;
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
