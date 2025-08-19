using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	[Obsolete()]
	public interface NaryI:nilnul.op_.NaryI< nilnul.num.RealI2>
	{
	}

	[Obsolete()]
	public class Nary : nilnul.op_.Nary<nilnul.num.RealI2>, NaryI
	{
		public Nary(num.RealI2 ret) : base(ret)
		{
		}


		

	}
}
