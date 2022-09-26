using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.co
{
	public class Departure : to_.Scalar4dblI
	{
		static public double To(double a,double b)
		{
			return	 Math.Sqrt(
				vec_.co.Variance.To(
					a,b
				)
			);
		}

		public double to((double, double) src)
		{
			return To(src.Item1,src.Item2);
		}


		static public Departure Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Departure>.Instance;
			}
		}

	}
}
