using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.axial_
{
	/// <summary>
	/// one component is 1, or -1.
	/// other components are all 0.
	/// </summary>
	/// alias:
	///		sign
	///		signature
	///		unitary.
	///			can act as a unit for the signed measure.
	///		unial
	///			like axial
	///
	[Obsolete(nameof(vec_.unial_.IAxisal))]
	public interface IUnital
		:INonnil
		,
		vec_.IUnial
	{
	}
}
