using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var
{
	public class Eq1 : IEqualityComparer<VarI>
	{
		public bool Equals(VarI x, VarI y)
		{
			return x == y;
			throw new NotImplementedException();
		}

		public int GetHashCode(VarI obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}

		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1>.Instance;
			}
		}

	}
}
