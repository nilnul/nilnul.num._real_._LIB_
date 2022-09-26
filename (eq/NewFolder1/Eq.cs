using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R=nilnul.num.RealI;

namespace nilnul.num.real
{
	[PossibleException]
	public class Eq : IEqualityComparer<R>
	{
		public bool Equals(R x, R y)
		{
			if( Object.ReferenceEquals(x, y))return true;
			if (x is Quotient && y is Quotient)
			{
				return (x as Quotient) == (y as Quotient);
			}

			else
			{
				throw new NotImplementedException(" It can only be infered on further information: the subtype(quotient), contains same cauchy, .... these information is in fact finite.");
			}

			throw new NotImplementedException();
		}

		public int GetHashCode(R obj)
		{
			throw new NotImplementedException();
		}
	}
}
