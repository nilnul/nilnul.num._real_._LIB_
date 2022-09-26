using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext
{
	public class Eq : IEqualityComparer<nilnul.num.real.ExtI>
	{
		public bool Equals(ExtI x, ExtI y)
		{
			if (x is ext_.inf_.Neg )
			{
				if (y is ext_.inf_.Neg)
				{
					return true;
				}
				return false;
			}
			if (x is ext_.Bare)
			{
				if (y is ext_.Bare)
				{
					return nilnul.num.real.Eq.Singleton.Equals(
						(x as ext_.Bare).val
						,
						(y as ext_.Bare).val
					);
				}
				return false;
			}
			if (x is ext_.inf_.Pos)
			{
				if (y is ext_.inf_.Pos)
				{
					return true;
				}
				return false;

			}
			throw new UnexpectedReachException();

			//throw new NotImplementedException();
		}

		public int GetHashCode(ExtI obj)
		{
			if (obj is ext_.inf_.Neg)
			{
				return -1;
			}
			if (obj is ext_.inf_.Pos)
			{
				return 1;
			}
			return nilnul.num.real.Eq.Singleton.GetHashCode((obj as ext_.Bare).val);
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}


		//static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

	}
}
