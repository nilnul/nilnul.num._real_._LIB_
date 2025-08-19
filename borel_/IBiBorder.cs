using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.borel_
{
	/// <summary>
	/// the intersection of <see cref="border"/> results in this.
	/// as this is borel, an algebra of borders, hence this can be empty like [-3,-5)
	/// </summary>
	/// <remarks>
	/// while <see cref="real.IBound"/> is <see cref="biborder_.IDwelt"/>
	/// </remarks>
	public interface IBiBorder
	{
	}
}
