using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.eq_
{

	/// <summary>
	/// if a[n] / b[n] -->1 as n--> _Inf.
	/// </summary>
	public interface AsymptoticI:
		IEqualityComparer<nilnul.num.real.StreamI>
	{
	}
}
