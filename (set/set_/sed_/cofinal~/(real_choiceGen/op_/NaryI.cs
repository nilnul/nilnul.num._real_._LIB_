using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI6;

namespace nilnul.num.real.op_
{
	public interface NaryI1:nilnul.obj.op_._nulary_.ret_.ClosedI< R>
	{
	}

	public class Nary1 : 
		nilnul.obj.op_._nary_.Ret<R>
		,
		NaryI1
	{
		public Nary1(R ret) : base(ret)
		{
		}


		

	}
}
