using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.eg_.tau
{

	static public class _DegreeX
	{
		public const double RADIAN_PER_DEGREE = Math.PI / 180;
		public const double DEGREE_PER_RADIAN = 180 / Math.PI;

		static public double Radians_0degrees(double degree) {
			return degree * RADIAN_PER_DEGREE;
		}

		static public double Degrees_0radians(double radians) {
			return radians * DEGREE_PER_RADIAN;
			//return radians /RADIAN_PER_DEGREE;
		}


	} 
}
