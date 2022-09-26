using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real._func_
{
	public interface ParsI:nilnul.obj._func_.ParsI<nilnul.num.real.var.Sortie>
	{
	}

	public abstract class ParsA
		:
		nilnul.obj._func_.Pars<nilnul.num.real.var.Sortie>
		,
		ParsI
	{
		public ParsA(Sortie pars) : base(pars)
		{
		}
	}
}
