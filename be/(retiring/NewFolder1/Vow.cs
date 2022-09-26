using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
[Obsolete()]
	public class Vow<TBe>
		:nilnul.obj.be.Vow2<nilnul.num.RealI,TBe>
		,
		nilnul.num.real.VowI1

		where TBe:nilnul.num.real.BeI,new()
	{

	}

[Obsolete()]
	public class Vow_xpn<TBe,TXpn>
		: nilnul.obj.be.vow_.be_.Defaultable<nilnul.num.RealI, TBe, TXpn>
		,
		nilnul.num.real.VowI1

		where TBe:nilnul.num.real.BeI,new()
		where TXpn:Exception,new()

	{
		public Vow_xpn(TXpn msg) : base(msg)
		{
		}
		
		public Vow_xpn():this(new TXpn())
		{

		}


	}
}
