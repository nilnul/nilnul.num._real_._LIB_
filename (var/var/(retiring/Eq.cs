using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var
{
	[Obsolete()]
	public class Eq : IEqualityComparer<VarI>
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
	}
}
