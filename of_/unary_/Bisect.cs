using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{

	public class Bisect4dbl :

		Unary4dblI
	{
		public double op(double par)
		{
			return par / 2;
			throw new NotImplementedException();
		}

		static public Bisect4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Bisect4dbl>.Instance;
			}
		}

	}
}
