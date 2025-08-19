using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.unial_
{
	/// <summary>
	/// at most one component is not nil.
	/// As this is normal, so the only component that is nonnil is 1 or -1.
	/// </summary>
	/// <remarks>
	/// <see cref="vec_.IOrientational"/>
	/// </remarks>
	/// <see cref="vec_.axial_.IUnial"/>
	/// alias:
	///		basis
	///		axis
	///		axisal
	///		axial
	///		std/canonical/regular/normal/unit
	///		<see cref="vec_.IOrientational"/>
	///			,like ordinal(tinged with cardinal)/oridnate
	///		
	///	vs:
	///		<see cref="vec_.ICanonical"/>
	///		<see cref="nilnul.num.real.vec_.IAxial"/>
	///
	///

	public interface IAxial:real.vec_.IUnial
	{
	}
}
