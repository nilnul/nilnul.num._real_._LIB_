using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonnil
{
	public class Vow:nilnul.num.real.be.Vow<be_.nil.Anto>
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}

	}

	public class Vow_divByNilXpn : nilnul.num.real.be.Vow_xpn<be_.nil.Anto, DivideByZeroException>
	{
		public Vow_divByNilXpn()
		{
		}
		public Vow_divByNilXpn(string s):this(new DivideByZeroException(s))
		{
		}


		public Vow_divByNilXpn(DivideByZeroException msg) : base(msg)
		{
		}

		static public Vow_divByNilXpn Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow_divByNilXpn>.Instance;
			}
		}

	}


}
