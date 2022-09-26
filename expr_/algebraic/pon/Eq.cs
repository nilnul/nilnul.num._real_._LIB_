using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.pon
{
	public class Eq
		: IEqualityComparer<Ponent>
	{
		public bool Equals(Ponent x, Ponent y)
		{
			return object.ReferenceEquals(x,y) || ( x.basis == y.basis && x.index == y.index );
			//throw new NotImplementedException();
		}

		public int GetHashCode(Ponent obj)
		{
			return obj.basis.GetHashCode() & obj.index.GetHashCode();
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
