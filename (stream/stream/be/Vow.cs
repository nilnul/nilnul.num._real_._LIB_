using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.be
{
	public class Vow<TBe, TXpn> 
		: nilnul.obj.be.Vow3<real.StreamI, TBe, TXpn>
		,
		nilnul.num.real.stream.VowI

		where TBe : real.stream.BeI
		where TXpn : Exception
	{
		public Vow(TBe be, TXpn xpn) : base(be, xpn)
		{
		}
	}
}
