using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// a, a*(a-1), ...
	/// </summary>
	///
	[Obsolete(nameof(Permutate) + " is preferred, as we first select 0 from a, and the result would be 1;",true)]
	public class Permutate
		:
		nilnul.num.real.stream_.slider.subsumed_.Prod
		,
		nilnul.num.real.stream_.SliderI
	{
		

		public Permutate(num.RealI val) : base(new nilnul.num.real.stream_.slider_.increment_.Minus(val))
		{
		}

		
	}


}
