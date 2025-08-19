using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pow
{
	public class Eq
		: IEqualityComparer<Pow_indexPositive>
	{
		public bool Equals(Pow_indexPositive x, Pow_indexPositive y)
		{
			return object.ReferenceEquals(x,y) || ( x.basis == y.basis && x.index.en == y.index.en );
			//throw new NotImplementedException();
		}

		public int GetHashCode(Pow_indexPositive obj)
		{
			return obj.basis.GetHashCode() & obj.index.en.GetHashCode();
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
