using nilnul.num.real.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.subsume_
{
	public interface AddI
		:nilnul.num.real.stream_.SliderI
		
		
	{


	}

	public class Add : Subsume_opDefault_add
		,AddI
	{
		public Add(SliderI val) : base(val)
		{
		}
	}




}
