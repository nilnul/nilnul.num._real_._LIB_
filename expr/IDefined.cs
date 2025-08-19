using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr
{
	/// <summary>
	/// the set where the expr doesnot throw;
	/// eg:
	///		1/x, the set is {x!=0}
	///		ln(x), where the set is x>0;
	/// </summary>
	/// alias:
	///		domain
	///		src
	///		
	internal class IDefined
	{
	}
}
