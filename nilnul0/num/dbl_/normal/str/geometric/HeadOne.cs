using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.doubl.normal.str.geometric
{
	public class HeadOne
	{
		static public double _Sum(double rate, int count_natural ) {

			return (1 - Math.Pow(rate, count_natural)) / (1 - rate);

		}
		static public double _Sum(double rate, BigInteger count_natural_smallToDouble ) {

			return (1 - Math.Pow(rate, (double)count_natural_smallToDouble)) / (1 - rate);

		}


	}
}
