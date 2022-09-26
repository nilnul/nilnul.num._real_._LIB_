using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.quad
{
	public class Variance : to_.Scalar4dblI
	{
		static public double To(double a,double b,double c,double d)
		{
			return		nilnul.num.real.str.to_.scalar_.SqSum.Singleton.op(
					a,b,c,d
			);
		}

		public double to((double, double, double,double) src)
		{
			return To(src.Item1,src.Item2,src.Item3,src.Item4);
		}


		static public Variance Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Variance>.Instance;
			}
		}

	}
}
