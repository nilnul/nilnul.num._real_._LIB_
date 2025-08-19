using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._pred
{
	/// <see cref="nilnul.num.real.IPred"/>
	/// <summary>
	/// each var is regarded as a dimension; the var's val is the coordinate on that dimensional axis;
	/// all vars's vals form a subspace.
	/// eg:
	///		x=1
	///		x is in {}
	///		x > 1
	///		x is in {1,2,3}
	/// </summary>
	public interface ISpace
		:nilnul.obj.ISet<num.real.IVec>
	{
	}
}
