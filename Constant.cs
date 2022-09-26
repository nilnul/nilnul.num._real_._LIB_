using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	public interface ConstantI:nilnul.obj.op_._nulary_.ret_.ClosedI< R>
	{
	}

	public class Constant : 
		nilnul.obj.op_._nary_.Ret<R>
		,
		ConstantI
	{
		public Constant(R ret) : base(ret)
		{
		}


		

	}
}
