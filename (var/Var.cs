using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	[Obsolete()]
	public interface VarI
		:nilnul.VarI1<R>, nilnul.obj.VarI5<nilnul.num.RealI>
	{

	}

	[Obsolete()]
	public class Var
		:

		nilnul.Var1<R>
		,
		
		VarI
	{

	}
}
