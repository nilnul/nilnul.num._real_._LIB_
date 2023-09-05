using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// 1, a, a*(a-1), ...
	/// </summary>
	public class Permutate1
		:
		nilnul.num.real.stream_.slider.cumulus_.opDefault_.Multi
		,
		nilnul.num.real.stream_.SliderI
	{
		

		public Permutate1(num.RealI val) : base(new nilnul.num.real.stream_.slider_.increment_.Minus(val))
		{
		}

		
	}


}
