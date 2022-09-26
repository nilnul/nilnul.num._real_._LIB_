using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.be_
{
	public class EitherZero : BeI
	{
		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return nilnul.num.real.co.be_.EitherNil.Singleton.be(
				obj.Item1.choice,
				obj.Item2.choice
			);
		}

		public bool be(Co obj)
		{
			return be(obj.Item1,obj.Item2);
			throw new NotImplementedException();
		}

		private bool be(num.RealI item1, num.RealI item2)
		{

			return nilnul.num._real.approach.generator.duo.be_.EitherNil.Singleton.be(
				item1.choice,
				item2.choice
			);
			throw new NotImplementedException();
		}


		static public EitherZero Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EitherZero>.Instance;
			}
		}

	}
}
