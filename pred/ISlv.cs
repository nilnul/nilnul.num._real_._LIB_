using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.pred
{
	/// space/env/scope/state: {x,y,z}
	/// <summary>
	/// a subspace where each var represents a dimension.
	/// eg:
	///		x isin {}, empty in linear space x
	///		x =1	, a point, in linear space x
	///		x+y=1	, a line in planar space x,y
	///		------
	///		
	///			x+y		=1
	///				z	=0
	///				, a line in stereo space: x,y,z
	/// </summary>
	/// <remarks>
	/// eg:
	///		a^2 + b^2 !=0, in planar: {a,b}. 
	/// </remarks>
	/// alias:
	///		constraint
	///		condition
	public interface ISlv
	{
	}
}
