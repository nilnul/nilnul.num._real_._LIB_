using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using D = nilnul.num.real.border.Co;

namespace nilnul.num.real.border.co.be_
{
	public class Single1 : BeI
	{
		public bool be(D obj)
		{
			return num.real.border.Eq1.Singleton.Equals(obj.lower , obj.upper);
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
