using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;
using D = nilnul.num.dbl.border.Co;

namespace nilnul.num.dbl.border.co.be_
{
	public class Dwelt : BeI
	{
		public bool be(D obj)
		{
			return Single.Lazy.be(obj) || Spanned.Lazy.be(obj);;
		}


		static public Dwelt Lazy
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Dwelt>.Instance;
			}
		}

	}
}