using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj_.xpn_;

namespace nilnul.num.real.stream.be_.piable
{
	public interface VowI:
		nilnul.obj._vow_.BlankI
		,
		nilnul.num.real.stream.VowI
	{

	}


	public class Vow<TXpn> : nilnul.num.real.stream.be.Vow<Piable, TXpn>
		where TXpn:Exception
	{
		public Vow(Piable be, TXpn xpn) : base(be, xpn)
		{
		}

		public Vow(ConvergentI val, TXpn xpn):this(new Piable(val), xpn)
		{

		}
	}

	public class Vow : Vow<obj_.xpn_.UnacceptableException<VowI>>
	{
		public Vow(Piable be, UnacceptableException<VowI> xpn) : base(be, xpn)
		{
		}

		public Vow(ConvergentI val, UnacceptableException<VowI> xpn) : base(val, xpn)
		{
		}
	}
}
