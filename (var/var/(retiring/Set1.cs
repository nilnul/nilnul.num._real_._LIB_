using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_;

namespace nilnul.num.real.var
{
	[Obsolete()]
	public class Set1 :
		nilnul.obj.var.Set<nilnul.num.RealI, nilnul.num.real.VarI >,

		nilnul.obj._set_.ContainsI<nilnul.num.real.VarI>

	{

		public Set1(params nilnul.num.real.VarI[] vars)
			:base(vars)
		{
			
		}
	}
}
