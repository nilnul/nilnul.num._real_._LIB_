using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.limit.duo.op
{
	public class Add
	{
		public class Call 
			:nilnul.obj.duo._call.Args_bothSameType<_real.CauchyI>
			,
			_real.CauchyI

		{

			public Call(_real.CauchyI x,_real.CauchyI y):base(x, y)
			{

			}
			public nilnul.num.quotient.ext.border.duo.be.Bound.Asserted bound
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public void converge(Positive.Asserted diameter)
			{
				throw new NotImplementedException();
			}
		}
	}
}
