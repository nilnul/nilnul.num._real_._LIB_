using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator_
{
	public class FroApproach<T>
		:
		FroApproach,
		GeneratorI
		where T:ApproachI1, new()
	{
		 
		public FroApproach( ):base(new T()  )
		{
 		}

 
	}
}
