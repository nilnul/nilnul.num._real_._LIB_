using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.mesh
{
	public interface ClonableI
		:
		real.MeshI
		,
		nilnul.obj.ClonableI<nilnul.num.real.MeshI>
	{

	}
}
