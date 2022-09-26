using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.op_.binary_.multi
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.cumulator_.OpDefault<Frac, Multi>

	{
		public Cumulator() : base(new Frac(1))
		{
		}
	}
}
