using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = System.Double;
using D = nilnul.num.dbl.border.Co;

namespace nilnul.num.dbl.border.co.be_
{
	public class Single : BeI
	{
		public bool be(D obj)
		{
			return num.dbl.border.Eq.Singleton.Equals(obj.lower , obj.upper);
		}


		static public Single Lazy
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Single>.Instance;
			}
		}

		

	}
}
