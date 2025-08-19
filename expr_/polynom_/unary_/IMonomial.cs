using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom_.unary_
{
	/// <summary>
	/// eg:
	///		3x^3
	///		3x^0
	///	ex:
	///		3x^3 +x
	///		3xy
	/// </summary>
	public interface IMonomial
		:IUniVariate
		,
		polynom_.IMonomial
	{
	}
}
