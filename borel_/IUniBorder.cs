using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.borel_
{
	/// <summary>
	/// uniborder.
	/// eg:
	///		[0, +inf)
	///		,
	///		[-inf, 5)
	/// </summary>
	/// alias:
	///		border
	///		just a border
	///		
	public interface IUniBorder :real.IBorel, real.IBorder
	{
	}
}
