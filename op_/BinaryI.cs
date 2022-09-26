using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.op_
{
	public interface BinaryI:
		nilnul.num.real.OpI
		//,
		//nilnul.obj.op_._binary_.retParPar1_.ClosedI< R>
		//,
		//nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<R>
		,
		nilnul.obj.op_.BinaryI<R>
	{

	}


}
