using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;

namespace nilnul.num.real.be_
{
	[Obsolete()]

	public class Nonnil
		: nilnul.num.real.BeI1
	{
		public bool be(num.RealI3 obj)
		{
			return nilnul.num._real.cauchy.be_.Nonnil.Singleton.be(obj.choice);
			//throw new NotImplementedException();
		}


		static public Nonnil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nonnil>.Instance;
			}
		}


	}
}
