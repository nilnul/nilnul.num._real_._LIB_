using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr
{
	public interface ReI
		:nilnul.obj.ReI< nilnul.num.real.ExprI>
	{
	}

	public abstract class ReA : ReI
	{
		public abstract bool re(ExprI a, ExprI b);
	}
}
