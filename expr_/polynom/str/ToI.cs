using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.str
{
	public interface ToI<T>
		:
		nilnul.obj.ToI<
			IEnumerable<Algebraic>
			,
		T>
	{

	}
}
