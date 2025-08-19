using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic_
{
	public class Multied
		:
		nilnul.obj.expr_.typed_.generi_.call_.Binary<
			nilnul.num.RealI
		>
		//,
		//nilnul.obj._call_.ArgArg1A<AlgebraicI>
		,
		AlgebraicI
	{
		public Multied( GeneriI<RealI> arg, GeneriI<RealI> arg1) : base(
			nilnul.num.real.op_.binary_.Multi.Singleton

			, arg, arg1)
		{
		}

		
	}
}
