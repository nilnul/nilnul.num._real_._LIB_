using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator.be;
using R = nilnul.num.RealI3;

namespace nilnul.num.real.be_
{
	[Obsolete()]
	static public class _NilX
	{
		static public bool Be(num.RealI3 obj) {
			return nilnul.num._real.cauchy.be_.Nil.Singleton.be( obj.choice);
		}
	}

	[Obsolete()]
	public class Nil
		: nilnul.num.real.BeI1
	{


		public bool be(R obj)
		{
			return _NilX.Be( obj);
			//throw new NotImplementedException();
		}

		static public Nil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nil>.Instance;
			}
		}
	}
}