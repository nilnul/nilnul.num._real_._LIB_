using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	static public class _EqX
	{
		static public bool Eq
			(R x, R y)
		{
			if( Object.ReferenceEquals(x, y))return true;

			return nilnul.num.real.be_.Nil.Singleton.be(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(x,y)
			);
		}
	}

	[PossibleException]
	public class Eq : IEqualityComparer<R>
	{

		public bool Equals
			(R x, R y)
		{
			return _EqX.Eq(x, y);

			//throw new NotImplementedException();
		}

		public bool eq(R x, int y) {
			return Equals(x, new nilnul.num.real_.Quotient(y));
		}
		public bool eq(int x1, R y) {
			return Equals(new nilnul.num.real_.Quotient(x1), y);
		}


		public int GetHashCode(R obj)
		{
			if (obj is nilnul.num.real_.Quotient q)
			{
				return nilnul.num.quotient.Eq2.Singleton.GetHashCode(q);
			}
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
