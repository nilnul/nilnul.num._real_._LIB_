using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;

namespace nilnul.num._real.cauchy_._wallis
{
	/// <summary>
/// converges very slowly
/// </summary>
	public class Approach : nilnul.num._real._cauchy.ApproachI
	{

		static private nilnul.num.quotient.slider_.cumulative_.Product GenProduct() { return Wallis.GenProduct(); }

		private nilnul.num.quotient.slider.window_.Two window = new nilnul.num.quotient.slider.window_.Two(
			GenProduct()
		);

		public Range1 range
		{
			get
			{
				return Range1.CreateOpen_orderIfNecessary(window.prev,window.current);
			}

		}

		public void squeeze(Positive1 diameter)
		{
			while (range.diameter >diameter)
			{
				window.moveNext();
			}
			

			//throw new NotImplementedException();
		}
	}
}
