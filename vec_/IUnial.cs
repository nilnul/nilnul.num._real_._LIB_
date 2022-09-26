using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_
{
	/// <summary>
	/// the norm is one
	/// eg:
	///		[1]
	///		,
	///		[-1]
	///		,
	///		[1/2, sqrt(3)/2]
	///		
	/// </summary>
	/// <remarks>
	/// <see cref="num.real.vec.be_.IUnial"/>
	/// </remarks>
	/// alias:
	///		normal
	///			but norm is also used as magnitude
	///		unital
	///			the length is one. This can be taken as a unit.
	///		unial
	///			like axial
	public interface IUnial:real.IVec
	{
	}
}
