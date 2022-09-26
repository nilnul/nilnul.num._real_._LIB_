using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.expr_;

namespace nilnul.num.real.var
{
	public class Set :
		nilnul.Set1<nilnul.num.real.VarI, nilnul.num.real.var.Eq1>
		,
		nilnul.var._set_.BlankI

	{

		public Set(params nilnul.num.real.VarI[] vars)
			:base(vars)
		{
			
		}
	}
}
