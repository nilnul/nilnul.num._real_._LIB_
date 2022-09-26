using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	[Obsolete()]
	public interface VarI:nilnul.VarI2<nilnul.num.RealI>,nilnul.obj.VarI5<nilnul.num.RealI>
	{
	}

	[Obsolete()]
	public class Var1:
		nilnul.Var2<nilnul.num.RealI>
		,
		VarI
	{

	}
}
