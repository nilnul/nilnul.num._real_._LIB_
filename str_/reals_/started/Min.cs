using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.str_.started
{
	public static  class _MinX
	{
		static public double Min(IEnumerable<double> doubleS_headed) { 

				if (doubleS_headed.Count()==1)
			{
				return doubleS_headed.First();
				
			}
			return Math.Min(doubleS_headed.First(),Min(doubleS_headed.Skip(1)));

		}
		static public double Min(params double[] doubleS_noEmpty) {
			return Min(doubleS_noEmpty as IEnumerable<double>);
			
		}
	}
}
