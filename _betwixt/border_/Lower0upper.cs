using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.border_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		fence
	///		guarded
	///		lower0upper
	/// </remarks>
	public interface ILower0upper
	{
	}

	public interface GuardedDblI:ILower0upper {
		bool contain(double x);
	}

}
