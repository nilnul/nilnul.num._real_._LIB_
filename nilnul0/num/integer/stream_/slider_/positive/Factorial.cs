using nilnul.obj.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.positive
{
	/// <summary>
	/// a cumulus.
	/// 1, 1*1,1*1*2, 1*1*2*3
	/// </summary>
	public class Factorial
		:
		nilnul.num.integer.stream_.slider.cumulus_.Product
		,
		positive.cumulus_.IMulti
	{
			
		public Factorial():base(new nilnul.num.integer.stream_.slider_.Positive())
		{
				
		}
	}
}
