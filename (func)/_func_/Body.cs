using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real._func_
{
	public interface BodyI:nilnul.obj._func_.BodyI<nilnul.num.real.ExprI>
	{
	}

	public class BodyA
		:
		nilnul.obj._func_.Body<
			nilnul.num.real.ExprI
		>
		,
		BodyI
	{
		public BodyA(ExprI body) : base(body)
		{
		}
	}
}
