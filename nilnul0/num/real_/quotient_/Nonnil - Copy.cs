using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real_.quotient.en_;

namespace nilnul.num.real_.quotient_
{
	[Obsolete()]
	public interface NonnilI
		
	{
		nilnul.num.real_.quotient.en_.Nonnil nonnil { get; }
	}
	public class Nonnil : nilnul.num.real_.quotient.en_.Nonnil
		,
		NonnilI
	{
		public Nonnil(Quotient1 val) : base(val)
		{
		}

		public quotient.en_.Nonnil nonnil => this;
	}
}
