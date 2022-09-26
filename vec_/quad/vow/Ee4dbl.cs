using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.quad.vow
{
	public class Ee4dbl :
		nilnul.obj.vow.Ee1<
			(double, double, double,double)
		>
	{
		public Ee4dbl((double, double, double,double) val, VowI2<(double, double, double,double)> vow) : base(val, vow)
		{
		}
	}
}
