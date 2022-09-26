using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.real._vector
{
	/// <summary>
	/// the dimension of a space is pre-set or fixed up before a vector is defined.
	/// </summary>
	public interface DimensionI
	{
		nilnul._num.bigint.be.Natural.Asserted dimension { get; }
	}
}
