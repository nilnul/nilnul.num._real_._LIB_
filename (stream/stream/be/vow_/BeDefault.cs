using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.be.vow_
{
	public class BeDefault<TBe, TXpn> : real.stream.be.Vow< TBe, TXpn>
		where TBe : real.stream.BeI,new()
		where TXpn : Exception
	{
		public BeDefault( TXpn xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}
	}
}
