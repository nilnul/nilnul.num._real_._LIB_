using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic
{
	public class Eq
		:
		IEqualityComparer<Algebraic>
	{
		public bool Equals(Algebraic x, Algebraic y)
		{
			///as we simplify, we simplify the operands first, as these simplification is kept, and the interim result simplification is lost.
			return object.ReferenceEquals(x,y) || (x - y).isNil();
			//return (x.asSimplify() - y.asSimplify()).asSimplify().scaleds.None();

		}

		public int GetHashCode(Algebraic obj)
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
