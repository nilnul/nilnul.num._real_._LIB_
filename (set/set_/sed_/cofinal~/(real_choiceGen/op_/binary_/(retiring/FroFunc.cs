using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.approach.generator.cofinal.duo.op_
{
	

	public class FroFunc
		
		:
		nilnul.duo.op_.froFunc_.Closed<CofinalI>
		,
		
		OpI
	{
		public FroFunc(Func<CofinalI,CofinalI,CofinalI> func):base(func)
		{

		}
		
	}
}
