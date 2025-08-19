using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.pons.prod.scaleds.sum
{
	public class Eq
		:
		IEqualityComparer<Sum>
	{
		public bool Equals(Sum x, Sum y)
		{
			///as we simplify, we simplify the operands first, as these simplification is kept, and the interim result simplification is lost.
			return object.ReferenceEquals(x,y) || (x - y).isNil();
			//return (x.asSimplify() - y.asSimplify()).asSimplify().scaleds.None();

		}

		public int GetHashCode(Sum obj)
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
