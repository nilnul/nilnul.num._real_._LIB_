using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach_;
using nilnul.num._real.cauchy.be_.nonnil.vow;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy_
{
	public interface NonnilI
	{
		cauchy.be_.nonnil.vow.En nonnil { get; }

	}


	public class Nonnil
	:
		cauchy.be_.nonnil.vow.En
			,
		NonnilI
		
	{
		

		public Nonnil(C val) : base(val)
		{
		}

		public En nonnil => this;
	}

}
