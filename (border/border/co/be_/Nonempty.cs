using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using D = nilnul.num.real.border.Co;

namespace nilnul.num.real.border.co.be_
{
	public class Nonempty1 : BeI
	{
		public bool be(D obj)
		{
			return Single1.Singleton.be(obj) || Spanned1.Singleton.be(obj);;
		}

		static public Nonempty1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonempty1>.Instance;
			}
		}
	}
}