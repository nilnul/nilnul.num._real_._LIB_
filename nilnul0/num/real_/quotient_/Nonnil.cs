using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real_.quotient.be_.nonnil.vow;

namespace nilnul.num.real_.quotient_
{
	public interface NonnilI1

	{
		nilnul.num.real_.quotient.be_.nonnil.vow.En quotient { get; }
	}
	public class Nonnil1 : nilnul.num.real_.quotient.be_.nonnil.vow.En
		,
		NonnilI1
	{
		public Nonnil1(Quotient val) : base(val)
		{
		}

		public En quotient => this;
	}
}
