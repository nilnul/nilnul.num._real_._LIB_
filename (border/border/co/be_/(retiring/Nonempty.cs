using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real.border.duo.be_
{
	public class Nonempty : BeI
	{
		public bool be(Duo obj)
		{
			return Single.Singleton.be(obj) || Spanned.Singleton.be(obj);;

			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted<Duo, Nonempty>
		{
			public En(Duo val) : base(val)
			{
			}

			static public En CreateClose(R x, R y) {
				return new En(
					Duo.CreateClose(x,y)	
				);
			}
			static public En CreateOpen(R x, R y) {
				return new En(
					Duo.CreateOpen(x,y)	
				);
			}

			static public En CreateClose(int x, int y) {
				return new En(
					Duo.CreateClose(x,y)	
				);
			}


		}
	}
}
