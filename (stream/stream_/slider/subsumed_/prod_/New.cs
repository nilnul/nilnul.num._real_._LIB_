using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;

namespace nilnul.num.real.stream_.slider.subsumed_.prod_
{
	

	public class New<T>

		: Prod
		where T: nilnul.num.real.stream_.SliderI,new()

	{
		public New() : base(new T())
		{
		}
	}

}
