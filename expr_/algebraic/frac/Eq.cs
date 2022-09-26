using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac
{
	public class Eq
		: IEqualityComparer<Frac>, EqI
	{
		public bool Equals(Frac x, Frac y)
		{

			return object.ReferenceEquals(x,y) || (x - y).isNil();
			//return (x.asSimplify() - y.asSimplify()).numerator.isNil();
			//return expr_.algebraic.Eq.Singleton.Equals(
			//	x.numerator * y.denominator
			//	,
			//	x.denominator * y.numerator
			//);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Frac obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq>.Instance;
			}
		}

	}
}
